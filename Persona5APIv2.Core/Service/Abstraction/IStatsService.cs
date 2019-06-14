using Persona5APIv2.Core.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persona5APIv2.Core.Service.Abstraction
{
    public interface IStatsService
    {
        Task<IEnumerable<PersonaStatsDTO>> ListAllPersonaStats();
    }
}
