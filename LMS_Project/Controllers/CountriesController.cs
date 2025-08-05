using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        ICountriesService Service;
        public CountriesController(ICountriesService service)
        {
            Service = service;
        }
        [HttpPost]
        [Route("AddCountry")]
        public IActionResult AddCountry([FromBody] CountryDto country)
        {
            Service.AddCountry(country);
            return Ok("Country added successfully");
        }
        [HttpGet]
        [Route("FetchAllCountries")]
        public IActionResult FetchAllCountries()
        {
            var data = Service.FetchAllCountries();
            return Ok(data);
        }
    }
}

  
