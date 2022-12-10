using Finger_Print_WebApi.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Finger_Print_WebApi.Data
{
    public class FingerPrintDBContext : DbContext
    {
        public FingerPrintDBContext(DbContextOptions<FingerPrintDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Department)
                .WithMany(y => y.Employees);
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Contract)
                .WithMany(e => e.Employees);
            modelBuilder.Entity<Attendance>()
                .HasOne(x => x.Employee)
                .WithMany(e => e.Attendances);
            modelBuilder.Entity<Mission>()
                .HasOne(x => x.Employee)
                .WithMany(e => e.Missions);
            modelBuilder.Entity<Permission>()
                .HasOne(x => x.Employee)
                .WithMany(e => e.Permissions);
            modelBuilder.Entity<Vacation>()
                .HasOne(x => x.Employee)
                .WithMany(e => e.Vacations);
            modelBuilder.Entity<Mtype>()
                .HasOne(x => x.Missions)
                .WithMany(e => e.Mtype);
            modelBuilder.Entity<Vtype>()
                .HasOne(x => x.Vacations)
                .WithMany(e => e.);
            modelBuilder.Entity<Vacation>()
                .HasOne(x => x.Employee)
                .WithMany(e => e.Vacations);



        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Mtype> Mtypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Ptype> Ptypes { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Vtype> Vtypes { get; set; }
        


    }
}
