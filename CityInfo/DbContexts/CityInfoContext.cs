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


        //first option to setup a database
        //protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("connectionstring");
        //     base.OnConfiguring(optionsBuilder);
        //}
    }
}
