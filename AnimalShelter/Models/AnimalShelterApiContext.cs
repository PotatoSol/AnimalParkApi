using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
    public class AnimalShelterApiContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options){
        }

            protected override void OnModelCreating(ModelBuilder builder){ //id, name, species, age john jacob jingleheimer schmidt
                builder.Entity<Animal>().HasData(
                new Animal { AnimalId = 1, Name = "John", Species = "Cat", Age = 5 },
                new Animal { AnimalId = 2, Name = "Jacob", Species = "Dog", Age = 6 },
                new Animal { AnimalId = 3,  Name = "Jingleheimer", Species = "Bird", Age = 7 },
                new Animal { AnimalId = 4, Name = "Schmidt", Species = "Fish", Age = 8 }
            );
        }
    }
}