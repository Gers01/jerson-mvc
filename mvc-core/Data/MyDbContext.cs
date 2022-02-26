using Microsoft.EntityFrameworkCore;
using mvc_core.Models;

namespace mvc_core.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Prestamos> Prestamos { get; set; } 
        public DbSet<Infopre> Infopre { get; set; }

    }
}
