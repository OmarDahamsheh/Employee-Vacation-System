using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_and_Vacation_Workflow_System.Entity;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_and_Vacation_Workflow_System
{
    public class EFDbContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<VacationType>VacationType { get; set; }
        public DbSet<RequestState>RequestState { get; set; }
        public DbSet<VacationRequest> VacationRequest { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS02;Initial Catalog=EmployeeManagmentAndVacationSystem;Integrated Security=True;TrustServerCertificate=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionId);

            modelBuilder.Entity<VacationRequest>()
                .HasOne(vr => vr.Employee)
                .WithMany(e => e.VacationRequests)
                .HasForeignKey(vr => vr.EmployeeNumber);
        
            modelBuilder.Entity<VacationRequest>()
                .HasOne(vr=>vr.VacationType)
                .WithMany(vt => vt.VacationRequests)
                .HasForeignKey(vr => vr.VacationTypeId);

            modelBuilder.Entity<VacationRequest>()
                .HasOne(vr=>vr.RequestS
                tate)
                .WithMany(rs => rs.VacationRequests)
                .HasForeignKey(vr => vr.RequestStateID);
        }
    }
}
