using System.ComponentModel.DataAnnotations;

namespace ShassiWPFApp.Entities;

public class HarnessDrawing : BaseEntity
{
    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? Harness { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? HarnessVersion { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? Drawing { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? DrawingVersion { get; set; }

    public ICollection<HarnessWire> HarnessWires { get; set; } = new List<HarnessWire>();
}