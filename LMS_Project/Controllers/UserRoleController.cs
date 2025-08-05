using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        IUserRolesService Service;
        public UserRoleController(IUserRolesService service)
        {
            Service = service;
        }
        [HttpPost]
        [Route("AddUserRole")]
        public IActionResult AddUserRole([FromBody] DTO.UserRoleDto userRole)
        {
            Service.AddUserRole(userRole);
            return Ok("User role added successfully");
        }
        [HttpGet]
        [Route("FetchAllUserRoles")]
        public IActionResult FetchAllUserRoles()
        {
            var data = Service.FetchAllUserRoles();
            return Ok(data);
        }
    }
}
