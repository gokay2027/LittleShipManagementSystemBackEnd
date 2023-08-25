using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class CaptainConfiguration : IEntityTypeConfiguration<Captain>
    {
        public void Configure(EntityTypeBuilder<Captain> builder)
        {
            
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Captain));
                        
            builder.Property(c=>c.Name).IsRequired();
            builder.Property(c=>c.Surname).IsRequired();

            builder.HasOne(c=>c.Company)
                .WithMany(c=>c.Captains)
                .HasForeignKey(c=>c.CompanyId);
        }
    }
}
