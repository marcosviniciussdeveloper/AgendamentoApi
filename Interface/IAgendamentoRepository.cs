namespace AgendamentoAPI.Interface
{
    public interface IAgendamentoRepository
    {
        void Incluir(Agendamento agendamento);

        void Alterar(Agendamento agendamento);

        void Excluir(int id);

        Task<IEnumerable<Agendamento>> SelecionarTodos();

   

        Task<bool> SaveAllChangesAsync();
    }
}
