using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tutorial_10_Doctor.Models;

namespace Tutorial_10_Doctor.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly PatientDbContext _context;

        public PatientController(PatientDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            return Ok(_context.Patient.ToList());
        }
        

    }
}