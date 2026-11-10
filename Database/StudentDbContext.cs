using AtkninNikita_kt_41_23.Models;
using Microsoft.EntityFrameworkCore;

namespace AtkninNikita_kt_41_23.Database
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
    }
}