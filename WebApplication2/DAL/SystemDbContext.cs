
using Microsoft.EntityFrameworkCore;
using YourApp.Models;

namespace YourApp.DAL

{

    public class PlantNurseryContext : DbContext

    {

        public PlantNurseryContext(DbContextOptions<PlantNurseryContext> options)

            : base(options)

        {

        }

        public DbSet<Nursery> Nurseries { get; set; }

        public DbSet<Species> Species { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Batch> Batches { get; set; }

        public DbSet<BatchEmployee> BatchEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Species>().HasData(
                new Species
                {
                    SpeciesId = 123,
                    LatinName = "Pinus sylvestris",
                    GrowthTimeInYears = 5
                },
                new Species
                {
                    SpeciesId = 321,
                    LatinName = "Quercus robur",
                    GrowthTimeInYears = 10
                }
            );

            modelBuilder.Entity<Nursery>().HasData(
                new Nursery
                {
                    NurseryId = 1,
                    Name = "Green Seedlings",
                    EstablishedDate = new DateOnly(2000, 3, 15)
                }

            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName  = "Anna",
                    LastName   = "Kowalska"
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName  = "Piotr",
                    LastName   = "Nowak"
                }
            );
            modelBuilder.Entity<Batch>().HasData(
                new Batch
                {
                    BatchId           = 1,
                    Quantity          = 100,
                    SownDate          = new DateTime(2025, 1, 10),
                    ReadyDate         = new DateTime(2025, 4, 10),
                    SpeciesLatinName  = "Pinus sylvestris",
                    NurseryId         = 1
                },
                new Batch
                {
                    BatchId           = 2,
                    Quantity          =  50,
                    SownDate          = new DateTime(2025, 2,  5),
                    ReadyDate         = new DateTime(2025, 7,  5),
                    SpeciesLatinName  = "Quercus robur",
                    NurseryId         = 1
                }
            );
            modelBuilder.Entity<BatchEmployee>().HasData(
                new BatchEmployee { BatchId = 1, EmployeeId = 1, Role = "Seeder"     },
                new BatchEmployee { BatchId = 2, EmployeeId = 2, Role = "Supervisor" }
            );

           

        }

    }

}
