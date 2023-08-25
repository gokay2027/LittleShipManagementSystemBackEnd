using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class JourneyConfiguration : IEntityTypeConfiguration<Journey>
    {
        public void Configure(EntityTypeBuilder<Journey> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Journey));

            builder.Property(c => c.GuessedJourneyTime).IsRequired();
            builder.Property(c => c.StartDockId).IsRequired();
            builder.Property(c => c.EndDockId).IsRequired();
            builder.Property(c => c.ShipId).IsRequired();
            builder.Property(c => c.CaptainId).IsRequired();

            builder.HasOne(j => j.StartDock)
                .WithMany(d => d.StartJourneyList)
                .HasForeignKey(d => d.StartDockId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(j => j.EndDock)
                .WithMany(d => d.EndJourneyList)
                .HasForeignKey(d => d.EndDockId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(j => j.Ship)
                .WithMany(s => s.Journeys)
                .HasForeignKey(j => j.ShipId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(j => j.Captain)
                .WithMany(c => c.Journeys)
                .HasForeignKey(c => c.CaptainId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany(j => j.Workers)
                .WithMany(j => j.Journeys);
        }
    }
}