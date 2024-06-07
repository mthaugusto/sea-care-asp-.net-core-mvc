using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_PARCEIROS")]
    public class Parceiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PARCEIRO")]
        public long Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column("NM_PARCEIRO")]
        public string NomeParceiro { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório.")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "CNPJ inválido. O formato correto é ##.###.###/####-##")]
        [MaxLength(18, ErrorMessage = "O CNPJ deve conter no máximo 18 caracteres.")]
        [Column("CNPJ")]
        public string Cnpj { get; set; }


        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O setor é obrigatório.")]
        [Column("SETOR")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email está inválido.")]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O status é obrigatório.")]
        [Range(0, 1, ErrorMessage = "O status deve estar entre 0 (inativo) e 1 (ativo).")]
        [Column("STATUS")]
        public int Status { get; set; }

        [Required(ErrorMessage = "A data de início é obrigatória.")]
        [Column("DT_INICIO")]
        public DateOnly DtInicio { get; set; }

        [Column("DT_FIM")]
        public DateOnly? DtFim { get; set; }

        public ICollection<Evento>? Eventos { get; set; } = new HashSet<Evento>();
    }
}
