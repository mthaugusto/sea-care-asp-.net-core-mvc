using Microsoft.EntityFrameworkCore;
using back_end_sea_care.Models;

namespace back_end_sea_care.Persistencia
{
    public class FiapDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Relato> Relatos { get; set; }

        public FiapDbContext(DbContextOptions<FiapDbContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}
