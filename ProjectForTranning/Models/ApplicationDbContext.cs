using Microsoft.EntityFrameworkCore;

namespace ProjectForTranning.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MVCFirstPro;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public ApplicationDbContext():base()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empolyee>().Property(x=> x.Address)
                        .HasMaxLength(250);
            modelBuilder.Entity<Department>().HasMany(x=>x.Empolyees).WithOne(x=>x.Department)
                        .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Empolyee> Empolyee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Tranee> tranees { get; set; }
        public DbSet<Instractor> instractors { get; set; }
        public DbSet<CourseResult> courseResults { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
