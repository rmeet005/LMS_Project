namespace LMS_Project.DTO
{
    public class GetCitiesDTO
    {
            public int CityId { get; set; }
            public string CityName { get; set; }
            public int StateId { get; set; }
            public string StateName { get; set; }
            public bool IsActive { get; set; }
        }
    }
