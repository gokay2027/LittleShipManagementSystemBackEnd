using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable(nameof(Company)).HasKey(x => x.Id);

            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Nation).IsRequired();

            builder.OwnsOne(p => p.Location);

            builder.HasMany(s => s.Ships)
                .WithOne(s => s.ShipCompany)
                .HasForeignKey(s => s.ShipCompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(cmp => cmp.Captains)
                .WithOne(c => c.Company)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Workers)
                .WithOne(c => c.Company)
                .HasForeignKey(w => w.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}