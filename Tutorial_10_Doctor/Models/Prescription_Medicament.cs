using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial_10_Doctor.Models
{
    public class Prescription_Medicament
    {
        [Key][ForeignKey("Medicament")] public int IdMedicament { get; set; }
        [Key][ForeignKey("Prescription")] public int IdPrescription { get; set; }
        public int Dose { get; set; }
        public string Details { get; set; }
        
    }
}