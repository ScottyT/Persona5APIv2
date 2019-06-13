using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Core.Data.Entity
{
    public class SkillsEntity : IEntity
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Effect { get; set; }
        public int Power { get; set; }
        public string CostAmount { get; set; }
        public string ElementName { get; set; }
        public virtual SkillCostEntity Cost { get; set; }
        public virtual ElementsEntity Element { get; set; }
    }
}
