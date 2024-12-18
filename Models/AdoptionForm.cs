using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAdoptionApp.Models
{
    public class AdoptionForm
    {
        [Required]
        public int AdoptionFormID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string DogName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string CurrentPets { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MonthlyIncome { get; set; }

        [RegularExpression(@"^(Pending|Approved|Denied)$")]
        public string? ApprovalStatus { get; set; }

        public string? Reasoning { get; set; }

    }
}
