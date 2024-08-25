using Microsoft.EntityFrameworkCore;
using ShassiWPFApp.Entities;
using ShassiWPFApp.Persistence.Configurations;
using ShassiWPFApp.Persistence.Extensions;

namespace ShassiWPFApp.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<HarnessDrawing> HarnessDrawings => Set<HarnessDrawing>();
    public DbSet<HarnessWire> HarnessWires => Set<HarnessWire>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new HarnessDrawingConfiguration());
        builder.ApplyConfiguration(new HarnessWiresConfiguration());
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        builder.SeedData();

        base.OnModelCreating(builder);
    }

    // NOTE: this override should not be required
    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //      => options.UseNpgsql("Host=localhost;Port=5432;Database=harness_db;Username=admin;Password=admin;Include Error Detail=true");
}
