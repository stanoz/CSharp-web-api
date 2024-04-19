using Microsoft.EntityFrameworkCore;
using StarWarsWebApplication.Entities;

namespace StarWarsWebApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Planet> StarWarsPlanets { get; set; }
    }
}
