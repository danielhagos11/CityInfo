using CityInfo.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInerest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("London")
                {
                    Id = 1,
                    Description = "The capital of Europe"
                },
                 new City("Antwerp")
                 {
                     Id = 2,
                     Description = "The center of Europe"
                 },
                 new City("Paris")
                 {
                     Id = 3,
                     Description = "The one with the big tower"
                 }
                );
            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("Central Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "The most visited urban park in UK"
                },
                 new PointOfInterest("Empire state building")
                 {
                     Id = 2,
                     CityId = 1,
                     Description = "A 100-story skyscraper located in UK"
                 },
                  new PointOfInterest("Cathedral")
                  {
                      Id = 3,
                      CityId = 2,
                      Description = "A 100-story skyscraper located in UK"
                  },
                   new PointOfInterest("Museum")
                   {
                       Id = 4,
                       CityId = 3,
                       Description = "A 100-story skyscraper located in UK"
                   }
                );
            base.OnModelCreating(modelBuilder);
        }


        //first option to setup a database
        //protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("connectionstring");
        //     base.OnConfiguring(optionsBuilder);
        //}
    }
}
