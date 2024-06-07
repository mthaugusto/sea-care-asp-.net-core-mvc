using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_RELATO")]
    public class Relato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_RELATO")]
        public long Id { get; set; }

        [Required]
        [Column("NM_RELATO")]
        public string NomeRelato { get; set; }

        [Required]
        [Column("DESCRICAO")]
        public string DescricaoRelato { get; set; }

        [Column("FOTO")]
        public string LinkFoto { get; set; }

        [Required]
        public long UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
