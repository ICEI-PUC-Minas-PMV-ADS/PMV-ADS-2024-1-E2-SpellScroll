using Microsoft.EntityFrameworkCore;
using spellScrollBackend.Models;

namespace Spells.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Spells.Any())
                {
                    return;   // DB has been seeded
                }
                context.Spells.AddRange(
                    new Spell
                    {
                     
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
