using ManageStudentScore.Datas;
using Microsoft.EntityFrameworkCore;

namespace ManageStudentScore.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Course> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public MyDBContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
