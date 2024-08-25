using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShassiWPFApp.Entities;

namespace ShassiWPFApp.Persistence.Configurations;

public class HarnessWiresConfiguration : IEntityTypeConfiguration<HarnessWire>
{
    public void Configure(EntityTypeBuilder<HarnessWire> builder)
    {
        builder.ToTable("Harness_wires");

        builder.Property(e => e.Id)
            .HasColumnName("ID");

        builder.Property(e => e.HarnessID)
            .HasColumnName("Harness_ID")
            .IsRequired();

        builder.Property(e => e.Length)
            .HasColumnName("Length")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.Property(e => e.Color)
            .HasColumnName("Color")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.Property(e => e.Housing1)
            .HasColumnName("Housing_1")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.Property(e => e.Housing2)
            .HasColumnName("Housing_2")
            .HasMaxLength(Constants.DEFAULT_VARCHAR_LENGHT);

        builder.HasIndex(e => e.Id)
            .HasDatabaseName("IX_Harness_wires_ID");
    }
}
