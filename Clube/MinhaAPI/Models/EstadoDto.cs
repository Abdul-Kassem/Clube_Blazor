using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class EstadoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do estado é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A sigla do estado é obrigatória")]
        public string Sigla { get; set; }
    }
}
