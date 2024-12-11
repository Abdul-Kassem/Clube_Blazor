using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class CidadeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O DDD é obrigatório.")]
        [StringLength(3, ErrorMessage = "O DDD deve ter no máximo 3 caracteres.")]
        public string DDD { get; set; }

        [Required(ErrorMessage = "O UF é obrigatório.")]
        public string EstadoId { get; set; }
    }
}
