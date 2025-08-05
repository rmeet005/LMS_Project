using LMS_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.DTO
{
    public class StatesDto
    {
     
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
       
        public bool IsActive { get; set; }
    }
}
