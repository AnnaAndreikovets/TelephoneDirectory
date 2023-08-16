using System.ComponentModel.DataAnnotations;

namespace TelephoneDirectory.Data.Models
{
    public class City
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CityName { get; set; } = null!;
    }
}