using AgendamentoAPI.Context;
using AgendamentoAPI.Controllers;
using AgendamentoAPI.Interface;
using Microsoft.EntityFrameworkCore;

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
            _Context.Entry(profissional).State = EntityState.Modified;
        }

        public void Incluir(Profissional profissional)
        {
            _Context.Profissionais.Add(profissional);
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Profissional>> SelecionarTodos()
        {
            return await _Context.Profissionais.ToListAsync();
        }


        public void Excluir(Guid Id)
        {
            _Context.Profissionais.Remove(new Profissional { Id = Id });
        }

  

        public async  Task<Profissional> SelecionarByPk(Guid id)
        {
           return await _Context.Profissionais
                .Include(x => x.Servicos)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }

}
    

    