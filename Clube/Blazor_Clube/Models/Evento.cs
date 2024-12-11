namespace Blazor_Clube.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; }
        public string EspacoLocavelId { get; set; }
        public string ResponsavelId { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public decimal ValorLocacao { get; set; }
    }
}
