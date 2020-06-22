using Microsoft.AspNetCore.Mvc;
using Tutorial_10_Doctor.DTOs.Requests;

namespace Tutorial_10_Doctor.Services
{
    public interface IDoctorDbService
    {
        public IActionResult GetDoctors();
        public IActionResult AddDoctor(DoctorRequest doctorRequest);
        public IActionResult UpdateDoctor(DoctorRequest doctorRequest);
        public IActionResult DeleteDoctor(DoctorRequest doctorRequest);

    }
}