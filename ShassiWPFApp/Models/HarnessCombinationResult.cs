namespace ShassiWPFApp.Models;

public class HarnessCombinationResult
{
    public string Harness1 { get; set; }
    public string HarnessVersion1 { get; set; }
    public string Harness2 { get; set; }
    public string HarnessVersion2 { get; set; }
    public string Housing { get; set; }
    public bool IsError { get; set; }
}