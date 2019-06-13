using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persona5APIv2.Core.Data.DTO
{
    public class SkillsDTO
    {
        public int Id { get; set; }

        [Required, MaxLength(25)]
        [Display(Name = "Name")]
        public string SkillName { get; set; }
        [Required, MaxLength(150)]
        public string Effect { get; set; }
        public int Power { get; set; }
        public string CostAmount { get; set; }
        public string ElementName { get; set; }

        public int CostId { get; set; }
        public SkillCostDTO Cost { get; set; }

        public int ElementId { get; set; }
        public ElementsDTO Element { get; set; }
    }
}
