using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class CitiesService : ICitiesService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public CitiesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddCity(CitiesDto city)
        {
            var data = mapper.Map<Cities>(city);
            db.Cities.Add(data);
            db.SaveChanges();
        }
        public List<CitiesDto> FetchAllCities()
        {
            var data = db.Cities.ToList();
            return mapper.Map<List<CitiesDto>>(data);
        }
        public void UpdateCity(CitiesDto city)
        {
            var data = mapper.Map<Cities>(city);
            db.Cities.Update(data);
            db.SaveChanges();
        }
        public void DeleteCity(int cityId)
        {
            var city = db.Cities.Find(cityId);
            if (city != null)
            {
                db.Cities.Remove(city);
                db.SaveChanges();
            }
        }
    }
}
