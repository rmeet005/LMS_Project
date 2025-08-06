using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IDocumentTypeService
    {
        public void AddDocumentType(DocumentTypeDto documentTypeDto);
        public List<DocumentTypeDto> FetchAllDocumentTypes();
        public void UpdateDocumentType(EditDocumentTypeDto documentTypeDto);
        public void DeleteDocumentType(int documentTypeId);
    }
}
