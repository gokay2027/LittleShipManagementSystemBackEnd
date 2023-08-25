using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Contract));

            builder.Property(c => c.LoadId).IsRequired();

            builder.OwnsOne(p => p.Fee);

            builder.HasOne(c => c.ShipLogisticCompany)
                .WithMany(c => c.ShipCompanyContracts)
                .HasForeignKey(c => c.ShipLogisticCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(c => c.CustomerCompany)
                .WithMany(c => c.CustomerCompanyContracts)
                .HasForeignKey(c => c.CustomerCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(j => j.Journey)
               .WithOne(c => c.Contract)
               .HasForeignKey<Contract>(a => a.JourneyId);

            builder.HasOne(l => l.Load)
                .WithOne(c => c.Contract);
        }
    }
}