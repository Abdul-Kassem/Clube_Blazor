using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Models;
using MinhaAPI.Services;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ProdutosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<Produto> GetProduto()
        {
            return context.Produto.OrderByDescending(c => c.Id).ToList();
        }

        [HttpGet("fornecedores")]
        public List<Fornecedor> GetFornecedores()
        {
            return context.Fornecedor.OrderBy(f => f.NomeRazaoSocial).ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduto(int id)
        {
            var produto = context.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);

        }

        [HttpPost]
        public IActionResult CreateProduto(ProdutoDto produtoDto)
        {

            var produto = new Produto
            {
                Nome = produtoDto.Nome,
                Descricao = produtoDto.Descricao,
                Preco = produtoDto.Preco,
                FornecedorId = produtoDto.FornecedorId
            };

            context.Produto.Add(produto);
            context.SaveChanges();

            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult EditProduto(int id, ProdutoDto produtoDto)
        {

            var produto = context.Produto.Find(id);

            produto.Nome = produtoDto.Nome;
            produto.Descricao = produtoDto.Descricao;
            produto.Preco = produtoDto.Preco;
            produto.FornecedorId = produtoDto.FornecedorId;


            context.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            var produto = context.Produto.Find(id);
            if (produto == null)
            {
                return NotFound();
            }

            context.Produto.Remove(produto);
            context.SaveChanges();

            return Ok(produto);
        }

    }
}
