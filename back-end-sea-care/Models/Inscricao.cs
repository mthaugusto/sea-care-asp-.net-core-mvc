using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_INSCRICAO")]
    public class Inscricao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_INSCRICAO")]
        public long Id { get; set; }

        [Required]
        [Column("DT_INSCRICAO")]
        public DateTime DataInscricao { get; set; }

        [Required]
        public long EventoId { get; set; }
        public Evento? Evento { get; set; }

        [Required]
        public long UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
