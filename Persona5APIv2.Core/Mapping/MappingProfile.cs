using AutoMapper;
using Persona5APIv2.Core.Data.DTO;
using Persona5APIv2.Core.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonaDTO, PersonaEntity>().ReverseMap();
            //CreateMap<SkillsDTO, SkillsEntity>().ReverseMap();
            CreateMap<PersonaStatsDTO, PersonaStatsEntity>().ReverseMap();
            //CreateMap<ElementsDTO, ElementsEntity>().ReverseMap();
            //CreateMap<SkillCostDTO, SkillCostEntity>().ReverseMap();
        }
    }
}
