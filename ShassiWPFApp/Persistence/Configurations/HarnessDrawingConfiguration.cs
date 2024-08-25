using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShassiWPFApp.Entities;

namespace ShassiWPFApp.Persistence.Configurations;

public class HarnessDrawingConfiguration : IEntityTypeConfiguration<HarnessDrawing>
{
    public void Configure(EntityTypeBuilder<HarnessDrawing> builder)
    {
        builder.ToTable("Harness_drawing");

        builder.Property(e => e.Id)
            .HasColumnName("ID");

        builder.Property(e => e.Harness)
            .HasColumnName("Harness")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.Property(e => e.HarnessVersion)
            .HasColumnName("Harness_version")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.Property(e => e.Drawing)
            .HasColumnName("Drawing")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.Property(e => e.DrawingVersion)
            .HasColumnName("Drawing_version")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.HasIndex(e => e.Id)
            .HasDatabaseName("IX_Harness_drawing_ID");

        builder.HasMany(h => h.HarnessWires)
            .WithOne(w => w.HarnessDrawing)
            .HasForeignKey(w => w.HarnessID);
    }
}
