using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;

namespace LMS_Project.Services
{
    public class CountriesService: ICountriesService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public CountriesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddCountry(CountryDto country)
        {
            var data = mapper.Map<Countries>(country);
            db.Countries.Add(data);
            db.SaveChanges();
        }
        public List<CountryDto> FetchAllCountries()
        {
            var data = db.Countries.ToList();
            return mapper.Map<List<CountryDto>>(data);
        }
    }
}
