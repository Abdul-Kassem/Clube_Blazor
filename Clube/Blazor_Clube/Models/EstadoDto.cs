using System.ComponentModel.DataAnnotations;

namespace Blazor_Clube.Models
{
    public class EstadoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
