using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace TelephoneDirectory.Data.Models
{
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; } = Guid.NewGuid();
        [BindRequired]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [BindRequired]
        public string? Surname { get; set; }
        [BindRequired]
        public string? Initials { get; set; }
        [BindRequired]
        public int? House { get; set; }
        public int? Building { get; set; }
        public int? Flat { get; set; }       
    }
}