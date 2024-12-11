using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspacosLocaveisController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public EspacosLocaveisController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<EspacoLocavel> GetEspacoLocavel()
        {
            return context.EspacoLocavel.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetEspacoLocavel(int id)
        {
            var espacolocavel = context.EspacoLocavel.Find(id);
            if (espacolocavel == null)
            {
                return NotFound();
            }

            return Ok(espacolocavel);

        }

        [HttpPost]
        public IActionResult CreateEspacoLocavel(EspacoLocavelDto espacolocavelDto)
        {

            var espacolocavel = new EspacoLocavel
            {
                NomeEspaco = espacolocavelDto.NomeEspaco,
                Tamanho = espacolocavelDto.Tamanho,
                CapacidadePessoas = espacolocavelDto.CapacidadePessoas,
                Locavel = espacolocavelDto.Locavel
            };

            context.EspacoLocavel.Add(espacolocavel);
            context.SaveChanges();

            return Ok(espacolocavel);
        }

        [HttpPut("{id}")]
        public IActionResult EditEspacoLocavel(int id, EspacoLocavelDto espacolocavelDto)
        {

            var espacolocavel = context.EspacoLocavel.Find(id);

            espacolocavel.NomeEspaco = espacolocavelDto.NomeEspaco;
            espacolocavel.Tamanho = espacolocavelDto.Tamanho;
            espacolocavel.CapacidadePessoas = espacolocavelDto.CapacidadePessoas;
            espacolocavel.Locavel = espacolocavelDto.Locavel;

            

            context.SaveChanges();

            return Ok(espacolocavel);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEspacoLocavel(int id)
        {
            var espacolocavel = context.EspacoLocavel.Find(id);
            if (espacolocavel == null)
            {
                return NotFound();
            }

            context.EspacoLocavel.Remove(espacolocavel);
            context.SaveChanges();

            return Ok(espacolocavel);
        }

    }
}
