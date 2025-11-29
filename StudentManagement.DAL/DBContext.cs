using Microsoft.EntityFrameworkCore;
using StudentManagementModel;

namespace StudentManagement.DAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    

   protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Configuration.StudentConfig());


          modelBuilder.ApplyConfiguration(new Configuration.CourseConfig());










        } }
}
