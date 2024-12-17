using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogAdoptionApp.Models;

namespace DogAdoptionApp.Data
{
    public class DogAdoptionAppContext : DbContext
    {
        public DogAdoptionAppContext (DbContextOptions<DogAdoptionAppContext> options)
            : base(options)
        {
        }

        public DbSet<DogAdoptionApp.Models.Dog> Dog { get; set; } = default!;
        public DbSet<DogAdoptionApp.Models.ShelterEvent> ShelterEvent { get; set; } = default!;
    }
}
