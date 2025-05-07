using FrontBackTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontBackTask.Contexts
{
    public class ProductDbContext :DbContext
    {
        private readonly string _connectionstring = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=ProductDB;Trusted_connection=True;TrustServerCertificate=True;";

      public  DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionstring);
            base.OnConfiguring(optionsBuilder);
        }

        
        
    }
}
