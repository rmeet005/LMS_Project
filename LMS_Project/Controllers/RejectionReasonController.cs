using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RejectionReasonController : ControllerBase
    {
        IRejectionReasonService service;
        public RejectionReasonController(IRejectionReasonService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddRejectionReason")]
        public IActionResult AddRejectionReason([FromBody] DTO.RejectionReasonDto rejectionReason)
        {
            service.AddRejectionReason(rejectionReason);
            return Ok("Rejection reason added successfully");
        }
        [HttpGet]
        [Route("FetchAllRejectionReasons")]
        public IActionResult FetchAllRejectionReasons()
        {
            var data = service.FetchAllRejectionReasons();
            return Ok(data);
        }
        [HttpPut]
        [Route("UpdateRejectionReason")]
        public IActionResult UpdateRejectionReason([FromBody] DTO.EditRejectionReasonDto rejectionReason)
        {
            service.UpdateRejectionReason(rejectionReason);
            return Ok("Rejection reason updated successfully");
        }
        [HttpDelete]
        [Route("DeleteRejectionReason/{rejectionReasonId}")]
        public IActionResult DeleteRejectionReason(int rejectionReasonId)
        {
            service.DeleteRejectionReason(rejectionReasonId);
            return Ok("Rejection reason deleted successfully");
        }
    }
}
