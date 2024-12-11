using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do evento é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O espaço locável é obrigatório.")]
        public string EspacoLocavelId { get; set; }

        [Required(ErrorMessage = "O responsável é obrigatório.")]
        public string ResponsavelId { get; set; }

        [Required(ErrorMessage = "A data de início é obrigatória.")]
        public string Inicio { get; set; }

        [Required(ErrorMessage = "A data de fim é obrigatória.")]
        public string Fim { get; set; }

        public decimal ValorLocacao { get; set; }
    }
}
