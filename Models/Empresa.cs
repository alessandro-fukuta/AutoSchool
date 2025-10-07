using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoSchool.Models
{
    [Table("empresa")]
    public class Empresa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Cnpj { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Endereco { get; set; }
        public string? Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Estado { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Cep { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime? DataFundacao { get; set; }
        public string? LogotipoUrl { get; set; }


    }
}