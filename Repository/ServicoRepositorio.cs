using AgendamentoAPI.Context;
using AgendamentoAPI.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AgendamentoAPI.Repository
{
    public class ServicoRepositorio : IServicoRepository
    {
        private readonly ApiContext _Context;

        public ServicoRepositorio(ApiContext context)
        {
            _Context = context;
        }

        public void Alterar(TipoServico servico)
        {
            _Context.Entry(servico).State = EntityState.Modified;
        }

        public void Excluir(Guid id)
        {
            _Context.Servicos.Remove(new TipoServico { Id = id }); 
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(TipoServico servico)
        {
            _Context.Servicos.Add(servico);
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<TipoServico>> SelecionarTodos()
        {
            return await _Context.Servicos
                .Include(x => x.Profissionais) 
                .ToListAsync();
        }
    }

}