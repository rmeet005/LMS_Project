using LMS_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.DTO
{
    public class CitiesDto
    {
      
        public int CityId { get; set; }
        public string CityName { get; set; }
        
        public int StateId { get; set; }
        public bool IsActive { get; set; }
      
    }
}
