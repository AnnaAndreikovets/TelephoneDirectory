using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string? Surname { get; set; }
        [BindRequired]
        [RegularExpression(@"[A-Za-z]\.[A-Za-z]\.")]
        public string? Initials { get; set; }
        [BindRequired]
        [Range(1, int.MaxValue)]
        public int? House { get; set; }
        [Range(1, int.MaxValue)]
        public int? Building { get; set; }
        [Range(1, int.MaxValue)]
        public int? Flat { get; set; }

        [ForeignKey("City")]
        public Guid CityId { get; set; }
        public City City { get; set; } = null!;
    }
}