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

            if (context == null || context.Dog == null)
            {
                throw new NullReferenceException("Null DogAdoptionAppContext or Dog DbSet");
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

            context.SaveChanges();
        }
        
    }
}
