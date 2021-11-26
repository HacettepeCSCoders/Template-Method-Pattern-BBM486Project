using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EmployeeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JIRLH52;Database=Employee;Trusted_Connection=true");
        }

        public DbSet<Intern> Interns { get; set; }
        public DbSet<JuniorSoftwareDeveloper> JuniorSoftwareDevelopers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ProjectManager> ProjectManagers { get; set; }
        public DbSet<QAEngineer> QAEngineers { get; set; }
        public DbSet<SoftwareDeveloper> SoftwareDevelopers { get; set; }
        public DbSet<SystemAnalyst> SystemAnalysts { get; set; }
        public DbSet<TestEngineer> TestEngineers { get; set; }
        public DbSet<UIDesigner> UIDesigners { get; set; }

    }
}