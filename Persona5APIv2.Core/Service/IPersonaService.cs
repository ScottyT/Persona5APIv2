using Persona5APIv2.Core.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Persona5APIv2.Core.Service
{
    public interface IPersonaService
    {
        Task<IEnumerable<PersonaDTO>> ListAllPersonasAsync();
        PersonaDTO GetPersonaAsync(int id);
        Task CreatePersonaAsync(PersonaDTO persona);
        Task<string> UploadPersonaImage(IFormFile imageFile);
    }
}
