using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_10_Doctor.Models;

namespace Tutorial_10_Doctor.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly PatientDbContext _context;

        public DoctorController(PatientDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctor.ToList());
        }

        [HttpPut]
        public IActionResult UpdateDoctor(Doctor doctor)
        {

            if (_context.Doctor.Any(e => e.IdDoctor == doctor.IdDoctor))
            {
                var d = _context.Doctor.Find(doctor.IdDoctor);
                d.FirstName = doctor.FirstName;
                d.LastName = doctor.LastName;
                d.Email = d.Email;
                _context.SaveChanges();
                return Ok("Doctor " + doctor.Email + " updated!");
            }
            else
            {
                return BadRequest("No doctor found");
            }
        }

        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
            if (_context.Doctor.Any(e => e.IdDoctor == doctor.IdDoctor))
            {
                return BadRequest("Doctor already exists.");
            }
            else
            {
                _context.Add(doctor);
                _context.SaveChanges();
                return Ok("Doctor " + doctor.Email + " added!");
            }
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(Doctor doctor)
        {
            if (_context.Doctor.Any(e => e.IdDoctor == doctor.IdDoctor))
            {
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