using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityApp.Models
{
    public class Province
    {
        [Key]
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        
        public List<City>? Cities { get; set; }
    }
}