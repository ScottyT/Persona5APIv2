using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Persona5APIv2.Core.Data.DTO;
using Persona5APIv2.Core.Service;

namespace Persona5APIv2.ClientWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonaService _personaService;
        public IEnumerable<PersonaDTO> Persona { get; set; }
        public HomeController(IPersonaService personaService)
        {
            _personaService = personaService;
        }
        public async Task<IActionResult> Index()
        {
            Persona = await _personaService.ListAllPersonasAsync();
            return View(Persona);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
