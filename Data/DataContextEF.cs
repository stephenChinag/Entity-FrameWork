using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entity.Data
{
    // private string connectionString  = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

    public class DataContextEF : DbContext
    {
        private IConfiguration _config;
        public DataContextEF(IConfiguration config) {
_config = config;
        }
                public DbSet<Computer> Computer {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;",
                options => options.EnableRetryOnFailure());
            }
        }
          protected override void OnModelCreating(ModelBuilder modelBuilder) {
           modelBuilder.HasDefaultSchema("TutorialAppSchema");
           modelBuilder.Entity<Computer>()
        //    .HasNoKey();
        .HasKey(c=>c.ComputeId);
        //    .ToTable("TableName", "SchemaName");
 }
    }
}