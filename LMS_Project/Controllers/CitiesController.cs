using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICitiesService Service;
        public CitiesController(ICitiesService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("AddCity")]
        public IActionResult AddCity([FromBody] CitiesDto city)
        {
            Service.AddCity(city);
            return Ok("City added successfully");
        }
        [HttpGet]
        [Route("FetchAllCities")]
        public IActionResult FetchAllCities()
        {
            var data = Service.FetchAllCities();
            return Ok(data);
        }
        [HttpPut]
        [Route("UpdateCity")]
        public IActionResult UpdateCity([FromBody] CitiesDto city)
        {
            Service.UpdateCity(city);
            return Ok("City updated successfully");
        }
        [HttpDelete]
        [Route("DeleteCity/{cityId}")]
        public IActionResult DeleteCity(int cityId)
        {
            Service.DeleteCity(cityId);
            return Ok("City deleted successfully");
        }
    }
}
