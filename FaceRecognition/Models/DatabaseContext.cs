using Microsoft.EntityFrameworkCore;
namespace FaceRecognition.Models
{
    public class DatabaseContext : DbContext
    {
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Database will save at "bin" file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Database");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            optionsBuilder.UseSqlite("Data Source=Database/database.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, StudentName = "Vu Bao", StudentId = "EEACIU19029"},
                new Student { Id = 2, StudentName = "Nguyen Duc Canh", StudentId = "EEACIU19031" },
                new Student { Id = 3, StudentName = "Trung Thanh", StudentId = "EEEEIU19031" }
                );
        }

        public DatabaseContext()
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<CheckDate> CheckDates { get; set; }

    }
}
