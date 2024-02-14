using Microsoft.EntityFrameworkCore;
using NexusUserBackend.Entities;


namespace NexusBackEndAPI
{
    public class ContextClass:DbContext
    {
        private IConfiguration configuration;
        public ContextClass(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Marks> Marks { get; set; } 
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Student> Students {  get; set; }
        public DbSet<Notification> notification { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<TeacherAttendance> TeacherAttendances { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
        }
    }
}
