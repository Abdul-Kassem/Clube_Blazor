using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public EstadosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Estado> GetEstado()
        {
            return context.Estado.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetEstado(int id)
        {
            var estado = context.Estado.Find(id);
            if (estado == null)
            {
                return NotFound();
            }

            return Ok(estado);

        }

        [HttpPost]
        public IActionResult CreateEstado(EstadoDto estadoDto)
        {

            var estado = new Estado
            {
                Nome = estadoDto.Nome,
                Sigla = estadoDto.Sigla,
            };

            context.Estado.Add(estado);
            context.SaveChanges();

            return Ok(estado);
        }

        [HttpPut("{id}")]
        public IActionResult EditEstado(int id, EstadoDto estadoDto)
        {

            var estado = context.Estado.Find(id);

            estado.Nome = estadoDto.Nome;
            estado.Sigla = estadoDto.Sigla;

            context.SaveChanges();

            return Ok(estado);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEstado(int id)
        {
            var estado = context.Estado.Find(id);
            if (estado == null)
            {
                return NotFound();
            }

            context.Estado.Remove(estado);
            context.SaveChanges();

            return Ok(estado);
        }

    }
}
