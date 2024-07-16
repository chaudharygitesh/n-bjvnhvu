using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.BAL.Dtos;
using SchoolManagement.BAL.ServiceInterface;
using SchoolManagement.DAL.Model;

namespace SchoolManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IService _service;
        public PatientController(IService service)
        {
            _service = service;
        }

        /* [HttpGet]
         public async Task<ActionResult<IEnumerable<Patient>>> GetPatientInfo()
         {
             return _service
         }*/
        [HttpGet]
        public async Task<IEnumerable<PatientDto>> GetInfoRegister()
        {
            return await _service.GetAllPatientDetail();
        }

        [HttpPost("AddPatient")]
        public async Task<IActionResult> RegisterPatient(PatientDto patientDto)
        {
            var res = await _service.AddPatient(patientDto);

            if(res == true)
            {
                return Ok(new {success = true});
            }

            return BadRequest(new { success = false });
        }


    }
}
