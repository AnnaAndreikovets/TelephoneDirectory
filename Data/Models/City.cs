using System.ComponentModel.DataAnnotations;

namespace TelephoneDirectory.Data.Models
{
    public class City
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; } = null!;
    }
}