using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_10_Doctor.DTOs.Requests;
using Tutorial_10_Doctor.Models;
using Tutorial_10_Doctor.Services;

namespace Tutorial_10_Doctor.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly PatientDbContext _context;

        private readonly IDoctorDbService _service;
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
            try
            {
                _service.UpdateDoctor(new DoctorRequest());
                return Ok(doctor);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            
        }

        [HttpPost]
        public IActionResult AddDoctor(DoctorRequest doctor)
        {
            try
            {
                _service.AddDoctor(doctor);
                return Ok(doctor);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(DoctorRequest doctor)
        {
            try
            {
                _service.DeleteDoctor(doctor);
                return Ok(doctor);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}