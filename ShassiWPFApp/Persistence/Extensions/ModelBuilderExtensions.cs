using Microsoft.EntityFrameworkCore;
using ShassiWPFApp.Entities;

namespace ShassiWPFApp.Persistence.Extensions;

public static class ModelBuilderExtensions
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HarnessDrawing>().HasData(
            new HarnessDrawing { Id = 40953, Harness = "S2563532M", HarnessVersion = "S-6", Drawing = "EP", DrawingVersion = "S-4" },
            new HarnessDrawing { Id = 40442, Harness = "S2563545M", HarnessVersion = "S12", Drawing = "EP", DrawingVersion = "S-4" },
            new HarnessDrawing { Id = 39087, Harness = "S2563549M", HarnessVersion = "S-9", Drawing = "EP", DrawingVersion = "S-4" },
            new HarnessDrawing { Id = 39077, Harness = "S2641137M", HarnessVersion = "S-9", Drawing = "EP", DrawingVersion = "S-4" },
            new HarnessDrawing { Id = 38643, Harness = "S2656843M", HarnessVersion = "5", Drawing = "EP", DrawingVersion = "S-4" }
        );

        modelBuilder.Entity<HarnessWire>().HasData(
            new HarnessWire { Id = 3115654, HarnessID = 38643, Length = "950", Color = "R", Housing1 = "C604:19", Housing2 = "P2.BX2:1" },
            new HarnessWire { Id = 3115655, HarnessID = 38643, Length = "450", Color = "R", Housing1 = "C604:23", Housing2 = "C521:1" },
            new HarnessWire { Id = 3158749, HarnessID = 39077, Length = "665", Color = "BN", Housing1 = "E71.B:1", Housing2 = "C604:21" },
            new HarnessWire { Id = 3158750, HarnessID = 39077, Length = "665", Color = "GR", Housing1 = "E71.B:4", Housing2 = "C604:23" },
            new HarnessWire { Id = 3159894, HarnessID = 39087, Length = "465", Color = "W", Housing1 = "E71.A:1", Housing2 = "C681" },
            new HarnessWire { Id = 3159895, HarnessID = 39087, Length = "680", Color = "SB", Housing1 = "E71.P:3", Housing2 = "G504-2" },
            new HarnessWire { Id = 3277678, HarnessID = 40442, Length = "475", Color = "GN", Housing1 = "P2.E85:1", Housing2 = "C680" },
            new HarnessWire { Id = 3277679, HarnessID = 40442, Length = "980", Color = "R", Housing1 = "P2.BX2:1", Housing2 = "E30.P:1" },
            new HarnessWire { Id = 3328453, HarnessID = 40953, Length = "365", Color = "W", Housing1 = "C621:6", Housing2 = "C681" },
            new HarnessWire { Id = 3328454, HarnessID = 40953, Length = "305", Color = "SB", Housing1 = "C620:24", Housing2 = "G508-3" }
        );
    }
}