namespace MinhaAPI.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AssociadoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é um campo obrigatório")]
        public string NomeTitular { get; set; }

        [Required(ErrorMessage = "O Endereço é um campo obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O Bairro é um campo obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O CEP é um campo obrigatório")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP inválido. Use o formato XXXXX-XXX.")]
        public string Cep { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "A cidade é um campo obrigatório")]
        public string CidadeId { get; set; }

        [Required(ErrorMessage = "O UF é um campo obrigatório")]
        public string EstadoId { get; set; }

        [Phone(ErrorMessage = "Celular inválido. Use um formato válido como (XX) XXXXX-XXXX.")]
        [RegularExpression(@"^\(?\d{2}\)?\s?\d{5}-\d{4}$", ErrorMessage = "Celular inválido. Use o formato (XX) XXXXX-XXXX.")]
        public string? Celular { get; set; }

        [Required(ErrorMessage = "O Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        public string? Facebook { get; set; }
        public string? Instagram { get; set; }

        [Required(ErrorMessage = "O CPF é um campo obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido. Use o formato XXX.XXX.XXX-XX.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O RG é um campo obrigatório")]
        [RegularExpression(@"^\d{1,2}\.\d{3}\.\d{3}-\d$", ErrorMessage = "RG inválido. Formato esperado: XX.XXX.XXX-X")]
        public string RegistroGeral { get; set; }

        [Required(ErrorMessage = "A data de nascimento é um campo obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "O tipo de associação é um campo obrigatório")]
        public string TipoDeAssociacao { get; set; }

    }

}
