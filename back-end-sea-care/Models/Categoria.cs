using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_CATEGORIA")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_CATEGORIA")]
        public long Id { get; set; }

        [Required]
        [Column("NM_CATEGORIA")]
        public string NomeCategoria { get; set; }
    }
}
