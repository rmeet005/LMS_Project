using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartmentService service;
        public DepartmentController(IDepartmentService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddDepartment")]
        public IActionResult AddDepartment([FromBody] DepartmentDto departmentDto)
        {
            service.AddDepartment(departmentDto);
            return Ok("Department added successfully.");
        }
        [HttpGet]
        [Route("FetchAllDepartments")]
        public IActionResult FetchAllDepartments()
        {
            var data = service.FetchAllDepartments();
            return Ok(data);
        }
    }
}
