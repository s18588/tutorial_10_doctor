using Microsoft.EntityFrameworkCore;

namespace Tutorial_10_Doctor.Models
{
    public class PatientDbContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }

        public PatientDbContext()
        {
        }

        public PatientDbContext(DbContextOptions options): base(options) 
        {
            
        }
    }
}