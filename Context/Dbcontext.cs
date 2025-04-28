using AgendamentoAPI.Controllers;
using AgendamentoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoAPI.Context
{
    public class Dbcontext : DbContext
    {
        
        public DbSet<profissionais> Profissionais { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        
    }
    

    }

