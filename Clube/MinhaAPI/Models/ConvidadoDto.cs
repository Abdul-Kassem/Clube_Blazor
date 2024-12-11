using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class ConvidadoDto
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
        public string RegistroGeral { get; set; }

        [Phone(ErrorMessage = "Celular inválido. Use um formato válido como (XX) XXXXX-XXXX.")]
        [RegularExpression(@"^\(?\d{2}\)?\s?\d{5}-\d{4}$", ErrorMessage = "Celular inválido. Use o formato (XX) XXXXX-XXXX.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "O email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O evento é um campo obrigatório")]
        public string EventoId { get; set; }
    }
}
