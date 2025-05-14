using CharityProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CharityProjectMVC.Contexts
{
    public class AppDbContext:DbContext
    {
        private readonly string _connection = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=CauseDb;Trusted_connection=True;TrustServerCertificate=True";

        public DbSet<Cause>causes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
