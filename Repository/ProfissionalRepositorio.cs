using AgendamentoAPI.Context;
using AgendamentoAPI.Interface;

namespace AgendamentoAPI.Repository
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly ApiContext _Context;

        public ProfissionalRepository(ApiContext context)
        {
            _Context = context;
        }

        public void Alterar(Profissional profissional)
        {
            _Context.Entry(profissional).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Profissional profissional)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            return await _Context.SaveChangesAsync() > 0;
        }

        public Task<Profissional> SelecionarByPk(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Profissional>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

        