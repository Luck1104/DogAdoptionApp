using System.ComponentModel.DataAnnotations;

namespace DogAdoptionApp.Components
{
    public class ShelterEvent
    {
        [Required]
        public int ShelterEventID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public String Name { get; set; }

        [Required]
        [Range(2024, 2124)]
        public int Year { get; set; }

        [Required]
        [Range(1, 12)]
        public int Month { get; set; }

        [Required]
        [Range(0, 31)]
        public int Day { get; set; }

        [Required]
        public String Location { get; set; }

        [Required]
        public String Time { get; set; }

        public string? Description { get; set; }
    }
}
