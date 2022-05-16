using Microsoft.AspNetCore.Mvc;
using Servicio.api.Libreria.Core.Entities;
using Servicio.api.Libreria.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicio.api.Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaServicioController : ControllerBase
    {

        private readonly IAutorRepository _autorRepository;

        private readonly IMongoRepository<AutorEntity> _autorGenericoRepositpry;
        public LibreriaServicioController(IAutorRepository autorRepository, IMongoRepository<AutorEntity> autorGenericoRepositpry)
        {
            _autorRepository = autorRepository;
            _autorGenericoRepositpry = autorGenericoRepositpry;
        }

        [HttpGet("autorGenerico")]
        public async Task<ActionResult<IEnumerable<AutorEntity>>> GetAutorGenerico()
        {

            var autores = await _autorGenericoRepositpry.GetAll();

            return Ok(autores);
        }

        [HttpGet("autores")]
        public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
        {

            var autores = await _autorRepository.GetAutores();

            return Ok(autores);
        }
    }
}
