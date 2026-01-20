using Microsoft.EntityFrameworkCore;
using WebAPI_Models_DTOs.DBContext.Models;

namespace WebAPI_Models_DTOs.DBContext
{
    public static  class DbSeeder
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
          ModelBuilder.Entity<InstrumentType>().HasData(
                new InstrumentType { Id = 1, TypeName = "String", Description = "String instruments produce sound from vibrating strings." },
                new InstrumentType { Id = 2, TypeName = "Wind", Description = "Wind instruments produce sound by the flow of air." },
                new InstrumentType { Id = 3, TypeName = "Percussion", Description = "Percussion instruments produce sound when struck or shaken." }
            );

        }
    }
}
