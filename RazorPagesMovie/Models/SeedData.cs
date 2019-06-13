using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDesk.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskContext(
                serviceProvider.GetRequiredService<DbContextOptions<MegaDeskContext>>()))
            {
                // Look for any Quotes.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Desk
                    {
                        name = "John Doe",
                        width = 30.00,
                        depth = 30.00,
                        numOfDrawers = 2,
                        price = 1025.00M,
                        material = "Rosewood",
                        rushOrder = "7 Days",
                        DateAdded = DateTime.Parse("2018-11-5")
                    }



                
                );
                context.SaveChanges();
            }
        }
    }
}
