using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService Service;
        public UserController(IUserService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(UserDto u)
        {
            Service.AddUser(u);
            return Ok(new { message = "User added" });  

        }

        [HttpGet]
        [Route("FetchAllUsers")]
        public IActionResult FetchAllUsers()
        {
            var data = Service.FetchAllUsers();
            return Ok(data);
        }
        [HttpPut]
        [Route("EditEmp")]
        public IActionResult EditEmp(EditUserDto u)
        {
            Service.UpdateUser(u);
            return Ok(new { message = "Emp updated" });
        }
        [HttpDelete]
        [Route("DeleteEmp/{uid}")]
        public IActionResult DeleteEmp(int uid)
        {
            Service.DeleteUser(uid);
            return Ok(new { message = "Emp deleted" });
        }
        [HttpGet]
        [Route("FindUserById/{uid}")]
        public IActionResult FindUserById(int uid)
        {
            var user = Service.FetchAllUsers().FirstOrDefault(u => u.Uid == uid);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }
            return Ok(user);
        }
    }
}
