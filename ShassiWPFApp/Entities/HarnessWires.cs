using System.ComponentModel.DataAnnotations;

namespace ShassiWPFApp.Entities;

public class HarnessWire : BaseEntity
{
    [Required]
    public int HarnessID { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? Length { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? Color { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? Housing1 { get; set; }

    [MaxLength(Constants.DEFAULT_VARCHAR_LENGHT)]
    public string? Housing2 { get; set; }

    public HarnessDrawing HarnessDrawing { get; set; }
}