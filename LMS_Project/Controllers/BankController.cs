using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        IBankService service;
        public BankController(IBankService service)
        {
            this.service = service;
        }
        [HttpPost("AddBank")]
        public IActionResult AddBank([FromBody] DTO.BankDto bank)
        {
            service.AddBank(bank);
            return Ok("Bank added successfully.");
        }
        [HttpGet("FetchAllBanks")]
        public IActionResult FetchAllBanks()
        {
            var banks = service.FetchAllBanks();
            return Ok(banks);
        }
        [HttpPut]
        [Route("UpdateBank")]
        public IActionResult UpdateBank([FromBody] DTO.EditBankDto bank)
        {
            service.UpdateBank(bank);
            return Ok("Bank updated successfully.");
        }
        [HttpDelete]
        [Route("DeleteBank/{bankId}")]
        public IActionResult DeleteBank(int bankId)
        {
            service.DeleteBank(bankId);
            return Ok("Bank deleted successfully.");
        }

    }
}
