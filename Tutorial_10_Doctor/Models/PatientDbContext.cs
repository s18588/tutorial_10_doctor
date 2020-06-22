using Microsoft.EntityFrameworkCore;
using Tutorial_10_Doctor.Models;

namespace Tutorial_10_Doctor.Models
{
    public class PatientDbContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }

        public PatientDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Prescription_Medicament>()
                .HasKey(c => new {c.IdMedicament, c.IdPrescription});
        }

        public PatientDbContext(DbContextOptions options): base(options) 
        {
        }
    }
}