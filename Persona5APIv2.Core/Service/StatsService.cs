using AutoMapper;
using Persona5APIv2.Core.Data;
using Persona5APIv2.Core.Data.DTO;
using Persona5APIv2.Core.Data.Entity;
using Persona5APIv2.Core.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona5APIv2.Core.Service
{
    public class StatsService : IStatsService
    {       
        private readonly IGenericRepository<PersonaStatsEntity> _repo;
        private readonly IMapper _mapper;

        public StatsService(IGenericRepository<PersonaStatsEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonaStatsDTO>> ListAllPersonaStats()
        {
            var stats = await _repo.GetAll();
            return stats.Select(e => _mapper.Map<PersonaStatsEntity, PersonaStatsDTO>(e));
        }
    }
}
