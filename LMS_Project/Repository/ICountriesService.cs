using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface ICountriesService
    {
        public void AddCountry(CountryDto country);
        public List<CountryDto> FetchAllCountries();
    }
}
