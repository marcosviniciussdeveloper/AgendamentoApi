using AgendamentoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoAPI.Infraestutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<_ProfissionaisController> Profissionais { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<TipoServico> TipoServicos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }


        public DbSet<ProfissionalTipoServico> ProfissionalTipoServicos { get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options, DbSet<_ProfissionaisController> profissionais, DbSet<Clientes> clientes, DbSet<TipoServico> tipoServicos, DbSet<ProfissionalTipoServico> profissionalTipoServicos) : base(options)
        {
            Profissionais = profissionais;
            Clientes = clientes;
            TipoServicos = tipoServicos;
            ProfissionalTipoServicos = profissionalTipoServicos;
        }


        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {
        }

        public ConnectionContext()
        {
        }
    }
}
