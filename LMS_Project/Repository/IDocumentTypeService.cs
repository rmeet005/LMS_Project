using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IDocumentTypeService
    {
        public void AddDocumentType(DocumentTypeDto documentTypeDto);
        public List<DocumentTypeDto> FetchAllDocumentTypes();
    }
}
