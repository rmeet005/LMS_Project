using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class DocumentTypeService : IDocumentTypeService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public DocumentTypeService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddDocumentType(DocumentTypeDto documentTypeDto)
        {
            var documentType = mapper.Map<DocumentType>(documentTypeDto);
            db.DocumentTypes.Add(documentType);
            db.SaveChanges();
        }
        public List<DocumentTypeDto> FetchAllDocumentTypes()
        {
            var data = db.DocumentTypes.ToList();
            return mapper.Map<List<DocumentTypeDto>>(data);

        }
    }
}
