using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        IRolesService Service;

        public RoleController(IRolesService service)
        {
            this.Service = service;

        }
        [HttpPost]
        [Route("AddRole")]
        public IActionResult AddRole(RolesDto roles)
        {
            Service.AddRole(roles);
            return Ok("Role Added Succefully!!");
        }
    }
}
