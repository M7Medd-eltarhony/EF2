using Assignment.Configurations;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Contexts
{
    internal class itiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = . ; Database = iti ; Trusted_Connection = true ;");

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(D =>
            {
                D.HasKey(nameof(Department.ID));
                D.Property(D => D.ID)
                .UseIdentityColumn(10, 10);

                D.Property(D => D.Name)
                .HasColumnName("DeptName")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .HasDefaultValue("Test")
                .IsRequired(false);

                D.Property(D => D.Ins_ID)
                .IsRequired(true);
            });

            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
