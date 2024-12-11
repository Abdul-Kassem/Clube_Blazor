using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public EventosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Evento> GetEvento()
        {
            return context.Evento.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("espacoslocaveis")]
        public List<EspacoLocavel> GetEspacoLocavel()
        {
            return context.EspacoLocavel.OrderBy(f => f.NomeEspaco).ToList();
        }

        [HttpGet("associados")]
        public List<Associado> GetAssociado()
        {
            return context.Associado.OrderBy(f => f.NomeTitular).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetEvento(int id)
        {
            var evento = context.Evento.Find(id);
            if (evento == null)
            {
                return NotFound();
            }

            return Ok(evento);

        }

        [HttpPost]
        public IActionResult CreateEvento(EventoDto eventoDto)
        {

            var evento = new Evento
            {
                Nome = eventoDto.Nome,
                Descricao = eventoDto.Descricao,
                EspacoLocavelId = eventoDto.EspacoLocavelId,
                ResponsavelId = eventoDto.ResponsavelId,
                Inicio = eventoDto.Inicio,
                Fim = eventoDto.Fim,
                ValorLocacao = eventoDto.ValorLocacao

            };

            context.Evento.Add(evento);
            context.SaveChanges();

            return Ok(evento);
        }

        [HttpPut("{id}")]
        public IActionResult EditEvento(int id, EventoDto eventoDto)
        {

            var evento = context.Evento.Find(id);

            evento.Nome = eventoDto.Nome;
            evento.Descricao = eventoDto.Descricao;
            evento.EspacoLocavelId = eventoDto.EspacoLocavelId;
            evento.ResponsavelId= eventoDto.ResponsavelId;
            evento.Inicio = eventoDto.Inicio;
            evento.Fim = eventoDto.Fim;
            evento.ValorLocacao = eventoDto.ValorLocacao;

            context.SaveChanges();

            return Ok(evento);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvento(int id)
        {
            var evento = context.Evento.Find(id);
            if (evento == null)
            {
                return NotFound();
            }

            context.Evento.Remove(evento);
            context.SaveChanges();

            return Ok(evento);
        }

    }
}