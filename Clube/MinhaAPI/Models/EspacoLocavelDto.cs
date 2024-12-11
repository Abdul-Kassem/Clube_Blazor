using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.Models
{
    public class EspacoLocavelDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do espaço é um campo obrigatório")]
        [StringLength(150, ErrorMessage = "O nome do espaço deve ter no máximo 150 caracteres")]
        public string NomeEspaco { get; set; }

        [Required(ErrorMessage = "O tamanho é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O tamanho deve ter no máximo 100 caracteres")]
        public string Tamanho { get; set; }

        [Required(ErrorMessage = "A capacidade de pessoas é um campo obrigatório")]
        [Range(1, 1000, ErrorMessage = "A capacidade de pessoas deve ser entre 1 e 1000")]
        public int CapacidadePessoas { get; set; }

        [Required(ErrorMessage = "A informação sobre locação é obrigatória")]
        public bool Locavel { get; set; }
    }
}
