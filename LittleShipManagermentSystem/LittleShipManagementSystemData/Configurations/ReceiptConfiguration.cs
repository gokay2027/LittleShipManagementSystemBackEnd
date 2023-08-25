using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Receipt));

            builder.HasOne(r => r.Contract)
                .WithOne(c => c.Receipt)
                .HasForeignKey<Receipt>(r => r.ContractId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}