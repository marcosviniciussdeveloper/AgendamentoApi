using Microsoft.EntityFrameworkCore;

namespace AgendamentoAPI.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

  
        public DbSet<ProfissionalTipoServico> ProfissionaisServicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoServico> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProfissionalTipoServico>()
                .HasKey(ps => new { ps.ProfissionalId, ps.ServicoId });

            modelBuilder.Entity<ProfissionalTipoServico>()
                .HasOne(ps => ps.Profissional)
                .WithMany(p => p.Servicos)
                .HasForeignKey(ps => ps.ProfissionalId);

            modelBuilder.Entity<ProfissionalTipoServico>()
                .HasOne(ps => ps.Servico)
                .WithMany(s => s.Profissionais)
                .HasForeignKey(ps => ps.ServicoId);

            modelBuilder.Entity<Agendamento>()
                .HasOne(a => a.Cliente)
                .WithMany(c => c.Agendamentos)
                .HasForeignKey(a => a.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Agendamento>()
                .HasOne(a => a.Profissional)
                .WithMany(p => p.Agendamentos)
                .HasForeignKey(a => a.ProfissionalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Agendamento>()
                .HasOne(a => a.Servico)
                .WithMany(s => s.Agendamentos)
                .HasForeignKey(a => a.ServicoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Cliente)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Profissional)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.ProfissionalId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}