using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class DependenteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é um campo obrigatório")]
        [StringLength(150, ErrorMessage = "O nome deve ter no máximo 150 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é um campo obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido. Use o formato XXX.XXX.XXX-XX.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O RG é um campo obrigatório")]
        [RegularExpression(@"^\d{1,2}\.\d{3}\.\d{3}-\d$", ErrorMessage = "RG inválido. Formato esperado: XX.XXX.XXX-X")]
        public string RG { get; set; }

        [Required(ErrorMessage = "A data de nascimento é um campo obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "O tipo de vínculo é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O tipo de vínculo deve ter no máximo 50 caracteres")]
        public string TipoVinculo { get; set; }

        [Required(ErrorMessage = "O associado titular é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do sócio titular associado deve ter no máximo 100 caracteres")]
        public string SocioTitular_Associado { get; set; }
    }
}
