using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tutorial_10_Doctor.DTOs.Requests;
using Tutorial_10_Doctor.Models;

namespace Tutorial_10_Doctor.Services
{
    public class DoctorDbService : ControllerBase, IDoctorDbService
    {
        
        private readonly PatientDbContext _context;

        public DoctorDbService(PatientDbContext context)
        {
            _context = context;
        }
        
        public IActionResult GetDoctors()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult AddDoctor(DoctorRequest doctorRequest)
        {
            if (_context.Doctor.Any(e => e.IdDoctor == doctorRequest.IdDoctor))
            {
                return BadRequest("Doctor already exists.");
            }
            else
            {
                var doctor = new Doctor()
                {
                    IdDoctor = doctorRequest.IdDoctor,
                    Email = doctorRequest.Email,
                    FirstName = doctorRequest.FirstName,
                    LastName = doctorRequest.LastName,
                    prescriptions = new List<Prescription>()
                };
                
                _context.Add(doctor);
                _context.SaveChanges();
                return Ok("Doctor " + doctor.Email + " added!");
            }
        }

        public IActionResult UpdateDoctor(DoctorRequest doctorRequest)
        {
            if (_context.Doctor.Any(e => e.IdDoctor == doctorRequest.IdDoctor))
            {
                var d = _context.Doctor.Find(doctorRequest.IdDoctor);
                d.FirstName = doctorRequest.FirstName;
                d.LastName = doctorRequest.LastName;
                d.Email = doctorRequest.Email;
                _context.SaveChanges();
                return Ok("Doctor " + doctorRequest.Email + " updated!");
            }
            else
            {
                return BadRequest("No doctor found");
            }
        }

        public IActionResult DeleteDoctor(DoctorRequest doctorRequest)
        {
            if (_context.Doctor.Any(e => e.IdDoctor == doctorRequest.IdDoctor))
            {
                var doctor = _context.Doctor.First(d => d.IdDoctor == doctorRequest.IdDoctor);
                _context.Doctor.Remove(doctor);
                _context.SaveChanges();
                return Ok("Doctor removed");
            }
            else
            {
                return BadRequest("Bad doctor");
            }
        }
    }
}