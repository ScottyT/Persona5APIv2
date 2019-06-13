using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Core.Data.Entity
{
    public class PersonaStatsEntity : IEntity
    {
        public int Id { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
    }
}
