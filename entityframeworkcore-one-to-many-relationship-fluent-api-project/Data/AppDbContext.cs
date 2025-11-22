using entityframeworkcore_one_to_many_relationship_project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace entityframeworkcore_one_to_many_relationship_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship between Doctor and Patient
            modelBuilder.Entity<Doctor>()
                .HasMany(d => d.Patients)
                .WithOne(p => p.Doctor)
                .HasForeignKey(p => p.DoctorID)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}