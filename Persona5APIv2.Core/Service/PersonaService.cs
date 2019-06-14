using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Persona5APIv2.Core.Data.DTO;
using Persona5APIv2.Core.Data.Entity;
using Persona5APIv2.Core.Data;
using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Persona5APIv2.Core.Logging;
using Persona5APIv2.Core.Service.Abstraction;

namespace Persona5APIv2.Core.Service
{
    public class PersonaService : IPersonaService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IGenericRepository<PersonaEntity> _repo;
        private readonly ILogger<PersonaService> _logger;
        private readonly IMapper _mapper;

        public PersonaService(IHostingEnvironment hostingEnvironment, ILogger<PersonaService> logger,
            IGenericRepository<PersonaEntity> repo, IMapper mapper)
        {
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }        

        public async Task<IEnumerable<PersonaDTO>> ListAllPersonasAsync()
        {
            try
            {
                var personas = await _repo.GetAll();
                _logger.LogInfo("Retrieved all Persona Entities from PersonaService.");

                var personasDTO = personas.Select(e => _mapper.Map<PersonaEntity, PersonaDTO>(e)).ToList();
                
                return personasDTO;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Unable to ListAllPersonas from PersonaService");
                return null;
            }
        }

        public PersonaDTO GetPersonaAsync(int id)
        {
            var persona = _repo.GetById(id);
            var personaDTO = _mapper.Map<PersonaEntity, PersonaDTO>(persona);
            return personaDTO;
        }

        public async Task CreatePersonaAsync(PersonaDTO personaDTO)
        {
            try
            {
                var personaEntity = _mapper.Map<PersonaDTO, PersonaEntity>(personaDTO);

                await _repo.Create(personaEntity);
                _logger.LogInfo($"Created new Persona in PersonaService. ID: {personaEntity.Id}");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Unable to create Persona in PersonaService");
            }
        }

        public Task<string> UploadPersonaImage(IFormFile imageFile)
        {
            throw new NotImplementedException();
        }
    }
}
