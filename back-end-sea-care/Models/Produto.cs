using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_PRODUTO")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PRODUTO")]
        public long Id { get; set; }

        [Required]
        [Column("NM_PRODUTO")]
        public string NomeProduto { get; set; }

        [Required]
        [Column("VL_PRODUTO", TypeName = "decimal(18, 2)")]
        public decimal ValorProduto { get; set; }

        [Required]
        [Column("LINK")]
        public string LinkProduto { get; set; }

        [Required]
        public long FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }

        [Required]
        public long CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
