using Microsoft.EntityFrameworkCore;
using ShassiWPFApp.Entities;
using ShassiWPFApp.Models;
using ShassiWPFApp.Persistence;

namespace ShassiWPFApp.Services;

public class HarnessService : IHarnessService
{
    private readonly IApplicationDbContext _context;

    public HarnessService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<HarnessCombinationResult>> GenerateAndValidateHarnessesAsync(int count)
    {
        // Generate a random set of harness pairs
        var harnesses = await _context.HarnessDrawings
            .Include(h => h.HarnessWires)
            .OrderBy(r => Guid.NewGuid())
            .Take(count)
            .ToListAsync();

        // Create pairs and validate them
        var pairs = GeneratePairs(harnesses);

        var displayData = pairs.Select(pair => new HarnessCombinationResult()
        {
            Harness1 = pair.Item1.HarnessDrawing.Harness!,
            HarnessVersion1 = pair.Item1.HarnessDrawing.HarnessVersion!,
            Harness2 = pair.Item2.HarnessDrawing.Harness!,
            HarnessVersion2 = pair.Item2.HarnessDrawing.HarnessVersion!,
            Housing = $"{pair.Item1.Housing1} / {pair.Item2.Housing2}",
            IsError = IsDuplicate(pair.Item1, pair.Item2)
        }).ToList();

        return displayData;
    }

    private List<Tuple<HarnessWire, HarnessWire>> GeneratePairs(List<HarnessDrawing> harnesses)
    {
        var pairs = new List<Tuple<HarnessWire, HarnessWire>>();
        var random = new Random();

        for (int i = 0; i < harnesses.Count - 1; i++)
        {
            var firstHarness = harnesses[i];
            var secondHarness = harnesses[random.Next(i + 1, harnesses.Count)];

            // Convert the ICollection to a List for indexing
            var firstHarnessWires = firstHarness.HarnessWires.ToList();
            var secondHarnessWires = secondHarness.HarnessWires.ToList();

            // Generate a pair from each harness
            if (firstHarnessWires.Count <= 0 || secondHarnessWires.Count <= 0)
            {
                continue;
            }

            var wire1 = firstHarnessWires[random.Next(firstHarnessWires.Count)];
            var wire2 = secondHarnessWires[random.Next(secondHarnessWires.Count)];
            pairs.Add(new Tuple<HarnessWire, HarnessWire>(wire1, wire2));
        }

        return pairs;
    }
    private bool IsDuplicate(HarnessWire wire1, HarnessWire wire2)
    {
        // Check if the two wires connect to the same housing and pin (indicating a duplicate)
        return (wire1.Housing1 == wire2.Housing1 && wire1.Housing1 != null) ||
               (wire1.Housing2 == wire2.Housing2 && wire1.Housing2 != null);
    }
}