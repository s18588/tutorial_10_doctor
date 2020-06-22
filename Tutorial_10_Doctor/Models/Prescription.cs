using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace Tutorial_10_Doctor.Models
{
    public class Prescription
    {
        [Key] public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("Patient")] 
        public int IdPatient { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("Doctor")] 
        public int IdDoctor { get; set; }
        public Doctor Doctor { get; set; }
    }
    
}