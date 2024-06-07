using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_end_sea_care.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_USUARIO")]
        public long Id { get; set; }

        [Required]
        [Column("NM_USUARIO")]
        public string NomeUsuario { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "O nível de permissão do usuário deve ser 0 (voluntário) ou 1 (voluntário-coordenador)")]
        [Column("NL_PERMISSAO")]
        public int NivelPermissao { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido. O formato correto é ###.###.###-##")]
        [Column("CPF")]
        public string Cpf { get; set; }

        [Required]
        [Column("LOGIN")]
        public string Login { get; set; }

        [Required]
        [Column("SENHA")]
        public string Senha { get; set; }

        [Required]
        [Column("CEP")]
        public string Cep { get; set; }

        [Required]
        [Column("EMAIL")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Column("TELEFONE")]
        public string Telefone { get; set; }
    }
}
