using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependentesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public DependentesController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Dependente> GetDependente()
        {
            return context.Dependente.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetDependente(int id)
        {
            var dependente = context.Dependente.Find(id);
            if (dependente == null)
            {
                return NotFound();
            }

            return Ok(dependente);

        }

        [HttpPost]
        public IActionResult CreateDependente(DependenteDto dependenteDto)
        {

            var dependente = new Dependente
            {
                Nome = dependenteDto.Nome,
                CPF = dependenteDto.CPF,
                RG = dependenteDto.RG,
                DataNascimento = dependenteDto.DataNascimento,
                TipoVinculo = dependenteDto.TipoVinculo,
                SocioTitular_Associado = dependenteDto.SocioTitular_Associado
            };

            context.Dependente.Add(dependente);
            context.SaveChanges();

            return Ok(dependente);
        }

        [HttpPut("{id}")]
        public IActionResult EditDependente(int id, DependenteDto dependenteDto)
        {

            var dependente = context.Dependente.Find(id);

            dependente.Nome = dependenteDto.Nome;
            dependente.CPF = dependenteDto.CPF;
            dependente.RG = dependenteDto.RG;
            dependente.DataNascimento = dependenteDto.DataNascimento;
            dependente.TipoVinculo = dependenteDto.TipoVinculo;
            dependente.SocioTitular_Associado = dependenteDto.SocioTitular_Associado;

            context.SaveChanges();

            return Ok(dependente);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDependente(int id)
        {
            var dependente = context.Dependente.Find(id);
            if (dependente == null)
            {
                return NotFound();
            }

            context.Dependente.Remove(dependente);
            context.SaveChanges();

            return Ok(dependente);
        }

    }
}

