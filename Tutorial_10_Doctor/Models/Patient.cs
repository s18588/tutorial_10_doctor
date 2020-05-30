using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_10_Doctor.Models
{
    public class Patient
    {
        [Key] public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}