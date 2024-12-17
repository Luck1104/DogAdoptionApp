using Microsoft.EntityFrameworkCore;
using DogAdoptionApp.Models;

namespace DogAdoptionApp.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new DogAdoptionAppContext(
            serviceProvider.GetRequiredService<DbContextOptions<DogAdoptionAppContext>>());

            if (context == null || context.Dog == null || context.ShelterEvent == null)
            {
                throw new NullReferenceException("Null DogAdoptionAppContext or Dog DbSet or ShelterEventDBSet");
            }

            if(context.Dog.Any())
            {
                return;
            }

            context.Dog.AddRange(
                new Dog
                {
                    Name = "Fido",
                    Age = 5,
                    Breed = "English Pointer",
                    Size = "Large",
                    Shelter = "Homeward Animal Shelter",
                    Description = "words words words",
                    AdoptionStatus = "Available"
                },
                new Dog
                {
                    Name = "Daisy",
                    Age = 2,
                    Breed = "Beagle",
                    Size = "Small",
                    Shelter = "Homeward Animal Shelter",
                    Description = "some other words",
                    AdoptionStatus = "Available"
                },
                new Dog
                {
                    Name = "Charlie",
                    Age = 7,
                    Breed = "Border Collie",
                    Size = "Medium",
                    Shelter = "Homeward Animal Shelter",
                    Description = "even more words",
                    AdoptionStatus = "Adopted"
                });

            context.ShelterEvent.AddRange(
                new ShelterEvent
                {
                    Name = "Fundraiser",
                    Year = 2024,
                    Month = 11,
                    Day = 25,
                    Location = "Homeward Animal Shelter",
                    Time = "10am",
                    Description = "words words words"
                },
                new ShelterEvent
                {
                    Name = "Movie",
                    Year = 2025,
                    Month = 8,
                    Day = 5,
                    Location = "Homeward Animal Shelter",
                    Time = "5pm",
                    Description = "some other words"
                },
                new ShelterEvent
                {
                    Name = "Potluck",
                    Year = 2026,
                    Month = 10,
                    Day = 15,
                    Location = "Homeward Animal Shelter",
                    Time = "4pm",
                    Description = "even more words"
                });

            context.SaveChanges();
        }
        
    }
}
