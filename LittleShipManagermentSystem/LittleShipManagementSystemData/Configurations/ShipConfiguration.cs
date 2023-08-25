using ListtleShipManagementSystemDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleShipManagementSystemData.Configurations
{
    public class ShipConfiguration : IEntityTypeConfiguration<Ship>
    {
        public void Configure(EntityTypeBuilder<Ship> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Ship));

            builder.Property(s=>s.ShipCompanyId).IsRequired();
            builder.Property(s=>s.Name).IsRequired();
            builder.Property(s=>s.ShipAge).IsRequired();
            builder.Property(s => s.RecordNumber).IsRequired().HasMaxLength(10);
            builder.Property(s => s.ShipNationality).IsRequired();
            //builder.Property(s => s.CurrentDockId).IsRequired();
            
        }
    }
}
