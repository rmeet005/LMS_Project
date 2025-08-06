using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentTypeController : ControllerBase
    {
        IEmploymentTypeService service;
        public EmploymentTypeController(IEmploymentTypeService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddEmploymentType")]
        public IActionResult AddEmploymentType([FromBody] EmploymentTypeDto employmentType)
        {
            service.AddEmploymentType(employmentType);
            return Ok("Employment type added successfully.");
        }
        [HttpGet]
        [Route("FetchAllEmploymentTypes")]
        public IActionResult FetchAllEmploymentTypes()
        {
            var data = service.FetchAllEmploymentTypes();
            return Ok(data);
        }
        [HttpPut]
        [Route("UpdateEmploymentType")]
        public IActionResult UpdateEmploymentType([FromBody] EditEmploymentTypeDto employmentType)
        {
            service.UpdateEmploymentType(employmentType);
            return Ok("Employment type updated successfully.");
        }
        [HttpDelete]
        [Route("DeleteEmploymentType/{employmentTypeId}")]
        public IActionResult DeleteEmploymentType(int employmentTypeId)
        {
            service.DeleteEmploymentType(employmentTypeId);
            return Ok("Employment type deleted successfully.");
        }
    }
}
