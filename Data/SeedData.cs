using Microsoft.EntityFrameworkCore;
using DogAdoptionApp.Models;
using DogAdoptionApp.Components;

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
                throw new NullReferenceException("Null DogAdoptionAppContext, Dog DbSet, or SHelterEvent DbSet");
            }

            if(context.Dog.Any())
            {
                return;
            }

            context.Dog.AddRange(
                new Dog
                {
                    Name = "Fido",
                    DogImage = "Images/dog1.jpg",
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
                    DogImage = "Images/dog2.jpg",
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
                    DogImage = "Images/dog3.jpg",
                    Age = 7,
                    Breed = "Border Collie",
                    Size = "Medium",
                    Shelter = "Homeward Animal Shelter",
                    Description = "even more words",
                    AdoptionStatus = "Adopted"
                });

            if (context.ShelterEvent.Any())
            {
                return;
            }

            context.ShelterEvent.AddRange(
                new ShelterEvent
                {
                    Name = "Christmas Party",
                    Year = 2024,
                    Month = 12,
                    Day = 25,
                    Location = "Homeward Animal Shelter",
                    Time = "5:00pm",
                    Description = "words words words"
                },
                new ShelterEvent
                {
                    Name = "Fundraiser",
                    Year = 2025,
                    Month = 6,
                    Day = 28,
                    Location = "Homeward Animal Shelter",
                    Time = "10:00am",
                    Description = "some other words"
                },
                new ShelterEvent
                {
                    Name = "Adoption Event",
                    Year = 2030,
                    Month = 1,
                    Day = 8,
                    Location = "Homeward Animal Shelter",
                    Time = "9:15pm",
                    Description = "even more words"
                });

            context.SaveChanges();
        }
        
    }
}
