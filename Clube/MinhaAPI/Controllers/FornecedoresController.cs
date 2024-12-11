using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public FornecedoresController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Fornecedor> GetFornecedor()
        {
            return context.Fornecedor.OrderByDescending(c => c.Id).ToList();
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
        public IActionResult GetFornecedor(int id)
        {
            var fornecedor = context.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return Ok(fornecedor);

        }

        [HttpPost]
        public IActionResult CreateFornecedor(FornecedorDto fornecedorDto)
        {

            var fornecedor = new Fornecedor
            {
                NomeRazaoSocial = fornecedorDto.NomeRazaoSocial,
                Endereco = fornecedorDto.Endereco,
                Bairro = fornecedorDto.Bairro,
                Numero = fornecedorDto.Numero,
                CEP = fornecedorDto.CEP,
                CidadeId = fornecedorDto.CidadeId,
                SiglaId = fornecedorDto.SiglaId,
                Celular = fornecedorDto.Celular,
                Email = fornecedorDto.Email,
                Facebook = fornecedorDto.Facebook,
                Instagram = fornecedorDto.Instagram
            };

            context.Fornecedor.Add(fornecedor);
            context.SaveChanges();

            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        public IActionResult EditeFornecedor(int id, FornecedorDto fornecedorDto)
        {

            var fornecedor = context.Fornecedor.Find(id);

            fornecedor.NomeRazaoSocial = fornecedorDto.NomeRazaoSocial;
            fornecedor.Endereco = fornecedorDto.Endereco;
            fornecedor.Bairro = fornecedorDto.Bairro;
            fornecedor.Numero = fornecedorDto.Numero;
            fornecedor.CEP = fornecedorDto.CEP;
            fornecedor.CidadeId = fornecedorDto.CidadeId;
            fornecedor.SiglaId = fornecedorDto.SiglaId;
            fornecedor.Celular = fornecedorDto.Celular;
            fornecedor.Email = fornecedorDto.Email;
            fornecedor.Facebook = fornecedorDto.Facebook;
            fornecedor.Instagram = fornecedorDto.Instagram;




            context.SaveChanges();

            return Ok(fornecedor);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFornecedor(int id)
        {
            var fornecedor = context.Fornecedor.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            context.Fornecedor.Remove(fornecedor);
            context.SaveChanges();

            return Ok(fornecedor);
        }

    }
}
