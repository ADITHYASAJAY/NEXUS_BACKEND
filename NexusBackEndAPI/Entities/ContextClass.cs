using Microsoft.EntityFrameworkCore;

namespace NexusBackEndAPI.Entities
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
        }
    }
}
