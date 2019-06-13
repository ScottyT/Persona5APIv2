using Persona5APIv2.Core.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona5APIv2.Infrastructure.Database
{
    public class ApplicationDbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context)
        {
            // ensure database is created
            context.Database.EnsureCreated();

            if (!context.Personas.Any())
                await SeedPersonas(context);
           
        }

        private static async Task SeedPersonas(ApplicationDbContext context)
        {
            var entities = new PersonaEntity[]
            {
                new PersonaEntity()
                {
                    Name = "Arsene",
                    Arcana = "Fool",
                    Level = 1,
                    Description = "A being based off the main character of Maurice Leblanc's novels, Arsene Lupin. He appears everywhere and is a master of disguise. He is known to help law-abiding citizens."
                    //Skills = null
                    //Stats = new PersonaStatsEntity()
                    //{
                    //    Strength = 2,
                    //    Magic = 2,
                    //    Endurance = 2,
                    //    Agility = 3,
                    //    Luck = 1
                    //},
                    //ResistElements = null,
                    //WeakElements = null,
                    //ImageFileName = null
                }
            };

            await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }
    }
}
