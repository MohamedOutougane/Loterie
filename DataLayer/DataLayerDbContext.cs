using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DataLayerDbContext : DbContext
    {
        public DataLayerDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Sessions> Sessions { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}