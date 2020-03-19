
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Severino.Models;

namespace Severino.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequisicaoReposta>()
                .HasKey(i => new { i.RequisicaoId, i.UsuarioId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Requisicao> Requisicao { get; set; }
        public DbSet<RequisicaoReposta> RequisicaoReposta { get; set; }
        public DbSet<Conversa> Conversa { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
    }
}
