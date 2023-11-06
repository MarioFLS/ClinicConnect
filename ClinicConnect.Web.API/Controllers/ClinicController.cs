using ClinicConnect.Application.DTOs;
using ClinicConnect.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicConnect.Web.API.Controllers
{
    [ApiController]
    [Route("clinics")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClinic([FromBody] ClinicDTO clinic)
        {
            if (clinic is null)
            {
                return BadRequest("O Body não pode ser nulo");
            }
            var result = await _clinicService.Add(clinic);
            return Ok(result);
        }
    }
}