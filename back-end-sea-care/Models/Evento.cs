using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_EVENTO")]
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_EVENTO")]
        public long Id { get; set; }

        [Required]
        [Column("NM_EVENTO")]
        public string NomeEvento { get; set; }

        [Required]
        [Column("DT_EVENTO")]
        public DateTime DataEvento { get; set; }

        [Required]
        [Column("TP_EVENTO")]
        public string TipoEvento { get; set; }

        [Required]
        [Column("DESCRICAO")]
        public string DescricaoEvento { get; set; }

        [Column("FOTO")]
        public string? Foto { get; set; }

        [Required]
        [Column("LOCAL")]
        public string Local { get; set; }

        [Column("NR_PARTICIPANTES")]
        public int NrParticipantes { get; set; }

        [Column("AVALIACAO")]
        public int? Avaliacao { get; set; }

        [Column("MEDIA_AVALIACOES")]
        public double? MediaAvaliacoes { get; set; }

        public ICollection<Parceiro>? Parceiros { get; set; } = new HashSet<Parceiro>();
    }
}
