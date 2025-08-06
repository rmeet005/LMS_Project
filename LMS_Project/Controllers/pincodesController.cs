using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LMS_Project.DTO;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pincodesController : ControllerBase
    {
        IPincodesService Service;
        public pincodesController(IPincodesService service)
        {
            Service = service;
        }
        [HttpPost]
        [Route("AddPincode")]
        public IActionResult AddPincode([FromBody] PinCodesDto pincode)
        {
            Service.AddPincode(pincode);
            return Ok("Pincode added successfully");
        }
        [HttpGet]
        [Route("FetchAllPincodes")]
        public IActionResult FetchAllPincodes()
        {
            var data = Service.FetchAllPincodes();
            return Ok(data);
        }
        [HttpPut]
        [Route("UpdatePincode")]
        public IActionResult UpdatePincode([FromBody] EditPincodesDto pincode)
        {
            Service.UpdatePincode(pincode);
            return Ok("Pincode updated successfully");
        }
        [HttpDelete]
        [Route("DeletePincode/{pincodeId}")]
        public IActionResult DeletePincode(int pincodeId)
        {
            Service.DeletePincode(pincodeId);
            return Ok("Pincode deleted successfully");
        }
    }
}

