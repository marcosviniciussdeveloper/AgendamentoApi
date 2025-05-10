using AgendamentoAPI.Context;
using AgendamentoAPI.Interface;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoAPI.Repository
{
    public class AgendamentoRepositorio : IAgendamentoRepository
    {
        private readonly ApiContext _Context;

        public AgendamentoRepositorio(ApiContext context)
        {
            _Context = context;
        }

        public void Alterar(Agendamento agendamento)
        {
            _Context.Entry(agendamento).State = EntityState.Modified;
        }

        public void Excluir(int id)
        {
            _Context.Agendamentos.Remove(new Agendamento { Id = id });
        }

        public void Incluir(Agendamento agendamento)
        {
            _Context.Agendamentos.Add(agendamento);
        }



        public async Task<bool> SaveAllChangesAsync()
        {
            return await _Context.SaveChangesAsync() > 0;
        }


        async Task<IEnumerable<Agendamento>> IAgendamentoRepository.SelecionarTodos()
        {
            return await _Context.Agendamentos
                 .Include(x => x.Profissional)
                 .Include(x => x.Servico)
                 .ToListAsync();
        }
    }
}