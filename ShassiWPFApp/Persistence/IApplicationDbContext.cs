using Microsoft.EntityFrameworkCore;
using ShassiWPFApp.Entities;

namespace ShassiWPFApp.Persistence;
public interface IApplicationDbContext
{
    DbSet<HarnessDrawing> HarnessDrawings { get; }
    DbSet<HarnessWire> HarnessWires { get; }
}