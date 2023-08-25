using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class LoadConfiguration : IEntityTypeConfiguration<Load>
    {
        public void Configure(EntityTypeBuilder<Load> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Load));

            builder.HasMany(l=>l.Containers)
                .WithOne(c => c.Load)
                .HasForeignKey(c => c.LoadId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}