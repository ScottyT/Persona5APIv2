using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Core.Data.Entity
{
    public class PersonaEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Arcana { get; set; }
        public virtual PersonaStatsEntity Stats { get; set; }
        public string Description { get; set; }
        //public string ImageFileName { get; set; }

        //public virtual SkillsEntity Skills { get; set; }
        //public virtual ElementsEntity ResistElements { get; set; }
        //public virtual ElementsEntity WeakElements { get; set; }
    }
}
