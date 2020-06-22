using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_10_Doctor.Models
{
    public class Doctor
    {
        
        [Key]
        public int IdDoctor { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public virtual ICollection<Prescription> prescriptions { get; set; }
        
    }
}