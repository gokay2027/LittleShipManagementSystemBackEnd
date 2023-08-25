using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleShipManagementSystemData.Configurations
{
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {

            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Worker));

            builder.Property(w=>w.CompanyId).IsRequired();
            builder.Property(w => w.Surname).IsRequired();
            builder.Property(w => w.Name).IsRequired();
            builder.Property(w => w.BirthDate).IsRequired();
            builder.Property(w => w.Experience).IsRequired();
            builder.Property(w => w.Nationality).IsRequired();
        
        }
    }
}