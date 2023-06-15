using ELearningApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ELearningApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString = 
            @"Data Source=LAB2INS;Initial Catalog=ELearningAppDB;Integrated Security=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(_connectionString);
        }

        public DbSet<Course> Courses { get; set; }
    }
}
