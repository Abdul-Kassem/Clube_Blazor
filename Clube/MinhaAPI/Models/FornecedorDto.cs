using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class FornecedorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome ou razão social é um campo obrigatório")]
        [StringLength(150, ErrorMessage = "O nome ou razão social deve ter no máximo 150 caracteres")]
        public string NomeRazaoSocial { get; set; }

        [Required(ErrorMessage = "O endereço é um campo obrigatório")]
        [StringLength(250, ErrorMessage = "O endereço deve ter no máximo 250 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O bairro é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O bairro deve ter no máximo 100 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O número é um campo obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O CEP é um campo obrigatório")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP inválido. Use o formato XXXXX-XXX.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O ID da cidade é um campo obrigatório")]
        public string CidadeId { get; set; }

        [Required(ErrorMessage = "O UF é um campo obrigatório")]
        public string SiglaId { get; set; }

        [Phone(ErrorMessage = "Celular inválido. Use um formato válido como (XX) XXXXX-XXXX.")]
        [RegularExpression(@"^\(?\d{2}\)?\s?\d{5}-\d{4}$", ErrorMessage = "Celular inválido. Use o formato (XX) XXXXX-XXXX.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "O Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }

    }
}
