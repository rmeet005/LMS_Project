using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        IStatesService Service;
        public StatesController(IStatesService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("AddState")]
        public IActionResult AddState(DTO.StatesDto state)
        {
            Service.AddState(state);
            return Ok("State added successfully");
        }
        [HttpGet]
        [Route("FetchAllStates")]
        public IActionResult FetchAllStates()
        {
            var data = Service.FetchAllStates();
            return Ok(data);
        }
        [HttpPut]
        [Route("UpdateState")]
        public IActionResult UpdateState(DTO.StatesDto state)
        {
            Service.UpdateState(state);
            return Ok("State updated successfully");
        }
        [HttpDelete]
        [Route("DeleteState/{stateId}")]
        public IActionResult DeleteState(int stateId)
        {
            Service.DeleteState(stateId);
            return Ok("State deleted successfully");
        }
    }
}