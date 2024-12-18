using System.ComponentModel.DataAnnotations;

namespace DogAdoptionApp.Models
{
    public class Dog
    {
        [Required]
        public int DogID { get; set; }

        public string? DogImage { get; set; }
        
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }
        
        [Required]
        [Range(0, 40)]
        public int Age { get; set; }
        
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Breed { get; set; }

        [Required]
        [RegularExpression(@"^(Small|Medium|Large)$")]
        public string Size { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Shelter { get; set; }
        
        public string? Description { get; set; }
        
        [Required]
        [RegularExpression(@"^(Available|Pending|Adopted)$")]
        public string AdoptionStatus { get; set; }

    }
}
