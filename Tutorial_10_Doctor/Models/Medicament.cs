using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_10_Doctor.Models
{
    public class Medicament
    {
        [Key]
        public int IdMedicament { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Type { set; get; }
        public virtual ICollection<Prescription_Medicament> pmedicaments { get; set; }

    }
}