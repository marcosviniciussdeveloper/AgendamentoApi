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

        public async Task<Profissional> SelecionarByPk(int id)
        {
            return await _Context.Profissionais.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Excluir(int Id)
        {
            var profissional = _Context.Profissionais.Find(Id);

            if ((profissional != null))
            {
                _Context.Profissionais.Remove(profissional);
            }
            
        }
    } 
}

        