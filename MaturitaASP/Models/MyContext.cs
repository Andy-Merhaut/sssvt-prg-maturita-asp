using MaturitaASP.Models.Bikes;
using Microsoft.EntityFrameworkCore;

namespace MaturitaASP.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Bike> Bike { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=bikes;user=root;password=");
        }
    }
}
