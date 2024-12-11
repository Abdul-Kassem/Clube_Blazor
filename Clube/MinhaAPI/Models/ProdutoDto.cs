using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class ProdutoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do produto é um campo obrigatório")]
        [StringLength(500, ErrorMessage = "A descrição do produto deve ter no máximo 500 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço é um campo obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O fornecedor do produto é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do fornecedor deve ter no máximo 100 caracteres")]
        public string FornecedorId { get; set; }
    }
}

