using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LittleShipManagementSystemData
{
    public class LittleShipManagementContext : DbContext
    {
        public LittleShipManagementContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CaptainConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new DockConfiguration());
            modelBuilder.ApplyConfiguration(new JourneyConfiguration());
            modelBuilder.ApplyConfiguration(new LoadConfiguration());
            modelBuilder.ApplyConfiguration(new ReceiptConfiguration());
            modelBuilder.ApplyConfiguration(new ShipConfiguration());
            modelBuilder.ApplyConfiguration(new WorkerConfiguration());
            modelBuilder.ApplyConfiguration(new ContainerConfiguration());

        }

        //Aggregate root

        //Entities

        public DbSet<Ship> Ships { get; set; }

        public DbSet<Dock> Docks { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Captain> Captains { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Journey> Journeys { get; set; }

        public DbSet<Load> Loads { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public DbSet<Worker> Workers { get; set; }

        public DbSet<Container> Containers { get; set; }
    }
}