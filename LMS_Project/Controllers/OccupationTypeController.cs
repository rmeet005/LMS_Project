using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupationTypeController : ControllerBase
    {
        IOccupationTypeService service;
        public OccupationTypeController(IOccupationTypeService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddOccupationType")]
        public IActionResult AddOccupationType([FromBody] OccupationTypeDto occupationTypeDto)
        {
            service.AddOccupationType(occupationTypeDto);
            return Ok("Occupation Type added successfully.");
        }
        [HttpGet]
        [Route("FetchAllOccupationTypes")]
        public IActionResult FetchAllOccupationTypes()
        {

            var data = service.FetchAllOccupationTypes();
            return Ok(data);

        }
    }
}
