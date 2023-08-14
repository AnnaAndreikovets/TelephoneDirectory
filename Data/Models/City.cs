using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TelephoneDirectory.Data.Models
{
    public class City
    {
        [BindRequired]
        public int Id { get; set; }
        [BindRequired]
        public string CityName { get; set; } = null!;
    }
}