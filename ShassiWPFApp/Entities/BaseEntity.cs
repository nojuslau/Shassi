using System.ComponentModel.DataAnnotations;

namespace ShassiWPFApp.Entities;

public abstract class BaseEntity
{
    [Required]
    [Key]
    public int Id { get; init; }
}
