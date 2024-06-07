using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_FORNECEDOR")]
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_FORNECEDOR")]
        public long Id { get; set; }

        [Required]
        [Column("NM_FORNECEDOR")]
        public string NomeFornecedor { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "CNPJ inválido. O formato correto é ##.###.###/####-##")]
        [Column("CNPJ")]
        public string Cnpj { get; set; }

        [Required]
        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Required]
        [Column("SETOR")]
        public string Setor { get; set; }
    }
}
