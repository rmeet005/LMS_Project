using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface ICitiesService
    {
        public void AddCity(CitiesDto city);
        public List<CitiesDto> FetchAllCities();

    }
}
