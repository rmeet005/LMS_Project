using LMS_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Project.DTO
{
    public class PinCodesDto
    {
   
        public int PincodeId { get; set; }
        public string Pincode { get; set; }
        public string? Area { get; set; }

       
        public int CityId { get; set; }
      

   
        public int StateId { get; set; }

       
        public int CountryId { get; set; }
   
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
