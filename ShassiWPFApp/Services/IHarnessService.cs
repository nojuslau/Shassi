using ShassiWPFApp.Models;

namespace ShassiWPFApp.Services;

public interface IHarnessService
{
    Task<List<HarnessCombinationResult>> GenerateAndValidateHarnessesAsync(int count);
}