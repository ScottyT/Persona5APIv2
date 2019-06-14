using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persona5APIv2.Core.Data.DTO;
using Persona5APIv2.Core.Service.Abstraction;

namespace Persona5APIv2.ClientWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPersonaService _personaService;
        private readonly IStatsService _statsService;

        public IEnumerable<PersonaDTO> Personas { get; set; }
        public IEnumerable<PersonaStatsDTO> Stats { get; set; }

        public IndexModel(IPersonaService personaService, IStatsService statsService)
        {
            _personaService = personaService;
            _statsService = statsService;
        }
        public async Task OnGetAsync()
        {
            Personas = await _personaService.ListAllPersonasAsync();
            Stats = await _statsService.ListAllPersonaStats();
        }
    }
}