using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TelephoneDirectory.Data.Models
{
    public class City
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [BindRequired]
        public string Name { get; set; } = null!;
    }
}