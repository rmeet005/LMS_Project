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
            var data = db.DocumentTypes.Where(x => x.IsDeleted == false).ToList();
            return mapper.Map<List<DocumentTypeDto>>(data);

        }
        public void UpdateDocumentType(EditDocumentTypeDto documentTypeDto)
        {
            var documentType = mapper.Map<DocumentType>(documentTypeDto);
            db.DocumentTypes.Update(documentType);
            db.SaveChanges();
        }
        public void DeleteDocumentType(int documentTypeId)
        {
            var documentType = db.DocumentTypes.Find(documentTypeId);
            if (documentType != null)
            {
                documentType.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}
