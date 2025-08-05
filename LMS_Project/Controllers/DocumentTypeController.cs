using LMS_Project.DTO;
using LMS_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        IDocumentTypeService service;
        public DocumentTypeController(IDocumentTypeService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("AddDocumentType")]
        public IActionResult AddDocumentType([FromBody] DocumentTypeDto documentTypeDto)
        {
            service.AddDocumentType(documentTypeDto);
            return Ok("Document Type added successfully.");
        }
        [HttpGet]
        [Route("FetchAllDocumentTypes")]
        public IActionResult FetchAllDocumentTypes()
        {
            var data = service.FetchAllDocumentTypes();
            return Ok(data);
        }
    }
}
