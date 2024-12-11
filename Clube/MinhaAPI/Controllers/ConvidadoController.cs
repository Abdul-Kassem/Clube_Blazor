using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvidadosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ConvidadosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Convidado> GetConvidado()
        {
            return context.Convidado.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("eventos")]
        public List<Evento> GetEventos()
        {
            return context.Evento.OrderBy(f => f.Nome).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetConvidado(int id)
        {
            var convidado = context.Convidado.Find(id);
            if (convidado == null)
            {
                return NotFound();
            }

            return Ok(convidado);

        }

        [HttpPost]
        public IActionResult CreateConvidado(ConvidadoDto convidadoDto)
        {

            var convidado = new Convidado
            {
                Nome = convidadoDto.Nome,
                CPF = convidadoDto.CPF,
                RegistroGeral = convidadoDto.RegistroGeral,
                Celular = convidadoDto.Celular,
                Email = convidadoDto.Email,
                EventoId = convidadoDto.EventoId

            };

            context.Convidado.Add(convidado);
            context.SaveChanges();

            return Ok(convidado);
        }

        [HttpPut("{id}")]
        public IActionResult EditConvidado(int id, ConvidadoDto convidadoDto)
        {

            var convidado = context.Convidado.Find(id);

            convidado.Nome = convidadoDto.Nome;
            convidado.CPF = convidadoDto.CPF;
            convidado.RegistroGeral = convidadoDto.RegistroGeral;
            convidado.Celular = convidadoDto.Celular;
            convidado.Email = convidadoDto.Email;   
            convidado.EventoId = convidadoDto.EventoId;
            

            context.SaveChanges();

            return Ok(convidado);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConvidado(int id)
        {
            var convidado = context.Convidado.Find(id);
            if (convidado == null)
            {
                return NotFound();
            }

            context.Convidado.Remove(convidado);
            context.SaveChanges();

            return Ok(convidado);
        }

    }
}
