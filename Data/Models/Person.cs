using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace TelephoneDirectory.Data.Models
{
    public class Person
    {
        public Guid PersonId { get; set; } = Guid.NewGuid();
        [BindRequired]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = null!;
        [BindRequired]
        public string Surname { get; set; } = null!;
        [BindRequired]
        public string Initials  { get; set; }  = null!;
        [BindRequired]
        public int House { get; set; }
        public int? Building  { get; set; }
        public int? Flat { get; set; }

        [BindRequired]
        public City City { get; set; } = null!;
    }
}