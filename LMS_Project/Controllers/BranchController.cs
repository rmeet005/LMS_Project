using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        IBranchService service;
        public BranchController(IBranchService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddBranch")]
        public IActionResult AddBranch([FromBody] BranchDto branchDto)
        {
            service.AddBranch(branchDto);
            return Ok("Branch added successfully.");
        }
        [HttpGet]
        [Route("FetchAllBranches")]
        public IActionResult FetchAllBranches()
        {
            var data = service.FetchAllBranches();
            return Ok(data);
        }
    }
}

