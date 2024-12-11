using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CidadesController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Cidade> GetCidade()
        {
            return context.Cidade.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("estados")]
        public List<Estado> GetEstados()
        {
            return context.Estado.OrderBy(f => f.Sigla).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetCidade(int id)
        {
            var cidade = context.Cidade.Find(id);
            if (cidade == null)
            {
                return NotFound();
            }

            return Ok(cidade);

        }

        [HttpPost]
        public IActionResult CreateCidade(CidadeDto cidadeDto)
        {

            var cidade = new Cidade
            {
                Nome = cidadeDto.Nome,
                DDD = cidadeDto.DDD,
                EstadoId = cidadeDto.EstadoId,
            };

            context.Cidade.Add(cidade);
            context.SaveChanges();

            return Ok(cidade);
        }

        [HttpPut("{id}")]
        public IActionResult EditCidade(int id, CidadeDto cidadeDto)
        {

            var cidade = context.Cidade.Find(id);

            cidade.Nome = cidadeDto.Nome;
            cidade.DDD = cidadeDto.DDD;
            cidade.EstadoId = cidadeDto.EstadoId;

            context.SaveChanges();

            return Ok(cidade);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCidade(int id)
        {
            var cidade = context.Cidade.Find(id);
            if (cidade == null)
            {
                return NotFound();
            }

            context.Cidade.Remove(cidade);
            context.SaveChanges();

            return Ok(cidade);
        }

    }
}
