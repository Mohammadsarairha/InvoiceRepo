using Alfakhouri.Models.DBEntites;
using Microsoft.EntityFrameworkCore;

namespace Alfakhouri.DAL
{
    public class CompDbContext : DbContext
    {
        public CompDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Items>? Items { get; set; }
        public DbSet<Units>? Units { get; set; }
        public DbSet<Stores>? Stores { get; set; }
    }
}
