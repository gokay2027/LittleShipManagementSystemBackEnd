using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class DockConfiguration : IEntityTypeConfiguration<Dock>
    {
        public void Configure(EntityTypeBuilder<Dock> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Dock));

            builder.OwnsOne(p => p.Location);

            builder.HasMany(d => d.Ships)
                .WithOne(d => d.Dock)
                .HasForeignKey(s => s.CurrentDockId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(j => j.StartJourneyList)
                .WithOne(d => d.StartDock)
                .HasForeignKey(d => d.StartDockId);

            builder.HasMany(j => j.EndJourneyList)
                .WithOne(d => d.EndDock)
                .HasForeignKey(d => d.EndDockId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}