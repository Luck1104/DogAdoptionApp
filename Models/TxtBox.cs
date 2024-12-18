using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAdoptionApp.Models
{
    public class TxtBox
    {
       
        public int Id { get; set; }

        public string? Content { get; set; }

        public string? ImageUrl { get; set; } // URL for the image
    }
}
