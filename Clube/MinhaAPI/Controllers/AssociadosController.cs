using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class AssociadosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public AssociadosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Associado> GetAssociado()
        {
            return context.Associado.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("estados")]
        public List<Estado> GetEstados()
        {
            return context.Estado.OrderBy(f => f.Sigla).ToList();
        }

        [HttpGet("cidades")]
        public List<Cidade> GetCidades()
        {
            return context.Cidade.OrderBy(f => f.Nome).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetAssociado(int id)
        {
            var associado = context.Associado.Find(id);
            if (associado == null)
            {
                return NotFound();
            }

            return Ok(associado);

        }

        [HttpPost]
        public IActionResult CreateAssociado(AssociadoDto associadoDto)
        {

            var associado = new Associado
            {
                NomeTitular = associadoDto.NomeTitular,
                Endereco = associadoDto.Endereco,
                Bairro = associadoDto.Bairro,
                Cep = associadoDto.Cep,
                Complemento = associadoDto.Complemento,
                CidadeId = associadoDto.CidadeId,
                EstadoId = associadoDto.EstadoId,
                Celular = associadoDto.Celular,
                Email = associadoDto.Email,
                Facebook = associadoDto.Facebook,
                Instagram = associadoDto.Instagram,
                CPF = associadoDto.CPF,
                RegistroGeral = associadoDto.RegistroGeral,
                DataNascimento = associadoDto.DataNascimento,
                TipoDeAssociacao = associadoDto.TipoDeAssociacao
            };

            context.Associado.Add(associado);
            context.SaveChanges();

            return Ok(associado);
        }

        [HttpPut("{id}")]
        public IActionResult EditeAssociado(int id, AssociadoDto associadoDto)
        {

            var associado = context.Associado.Find(id);

            associado.NomeTitular = associadoDto.NomeTitular;
            associado.NomeTitular = associadoDto.NomeTitular;
            associado.Endereco = associadoDto.Endereco;
            associado.Bairro = associadoDto.Bairro;
            associado.Cep = associadoDto.Cep;
            associado.Complemento = associadoDto.Complemento;
            associado.CidadeId = associadoDto.CidadeId;
            associado.EstadoId = associadoDto.EstadoId;
            associado.Celular = associadoDto.Celular;
            associado.Email = associadoDto.Email;
            associado.Facebook = associadoDto.Facebook;
            associado.Instagram = associadoDto.Instagram;
            associado.CPF = associadoDto.CPF;
            associado.RegistroGeral = associadoDto.RegistroGeral;
            associado.DataNascimento = associadoDto.DataNascimento;
            associado.TipoDeAssociacao = associadoDto.TipoDeAssociacao;


            context.SaveChanges();

            return Ok(associado);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAssociado(int id)
        {
            var associado = context.Associado.Find(id);
            if (associado == null)
            {
                return NotFound();
            }

            context.Associado.Remove(associado);
            context.SaveChanges();

            return Ok(associado);
        }

    }
}
