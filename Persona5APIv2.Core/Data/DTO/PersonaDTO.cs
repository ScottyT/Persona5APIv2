using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persona5APIv2.Core.Data.DTO
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(25)]
        public string Name { get; set; }
        public int Level { get; set; }
        public string Arcana { get; set; }
        public int StatsId { get; set; }
        public PersonaStatsDTO Stats { get; set; }
        [Required, MaxLength(250)]
        public string Description { get; set; }
        //public string ImageFileName { get; set; }
        //public List<int> SkillsId { get; set; }
        //public List<SkillsDTO> Skills { get; set; }

        //public List<int> ResistElementsId { get; set; }
        //[Display(Name = "Resists")]
        //public List<ElementsDTO> ResistElements { get; set; }

        //public List<int> WeakElementsId { get; set; }
        //[Display(Name = "Weak")]
        //public List<ElementsDTO> WeakElements { get; set; }
    }
}
