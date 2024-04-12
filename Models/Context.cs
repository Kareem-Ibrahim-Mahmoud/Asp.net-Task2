using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace asptask2.Models
{
    public class Context :DbContext
    {
        public DbSet<Anstructor> anstructors { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Trainee> trainees { get; set; }
        public DbSet<Course> courses { get; set; }  
        public DbSet<CourseResult> courseResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=.;Initial catalog=Asptask2;Integrated security=true");
            base.OnConfiguring(optionsBuilder); 
        }


    }
}
