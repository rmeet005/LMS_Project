using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface ICitiesService
    {
        public void AddCity(CitiesDto city);
        public List<GetCitiesDTO> FetchAllCities();
        public void UpdateCity(CitiesDto city);
        public void DeleteCity(int cityId);


    }
}
