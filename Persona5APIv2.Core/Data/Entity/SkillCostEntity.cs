using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Core.Data.Entity
{
    public class SkillCostEntity : IEntity
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Resource { get; set; }
    }
}
