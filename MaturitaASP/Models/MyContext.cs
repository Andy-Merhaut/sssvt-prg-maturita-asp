using Microsoft.EntityFrameworkCore;

namespace MaturitaASP.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=yourdatabase;user=yourusername;password=yourpassword");
        }
    }
}
