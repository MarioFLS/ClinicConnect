using AutoMapper;
using ClinicConnect.Application;
using ClinicConnect.Application.Commands;
using ClinicConnect.Application.DTOs;
using ClinicConnect.Domain.Entites;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicConnect.Web.API.Controllers
{
    [ApiController]
    [Route("doctors")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromBody] DoctorDTO doctor)
        {
            if (doctor is null)
            {
                return BadRequest("O Body não pode ser nulo");
            }
            var id = await _doctorService.Add(doctor);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            return Ok(new Doctor("name", "email", "phone", "specialization"));
        }
    }
}