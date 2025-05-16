namespace AgendamentoAPI.Interface
{
    public interface IProfissionalRepository
    {
        void Incluir(Profissional profissional);
        void Alterar(Profissional profissional);
        void Excluir(Guid Id);

        Task<Profissional> SelecionarByPk(Guid id);
        Task<IEnumerable<Profissional>> SelecionarTodos();

        Task<bool>SaveAllChangesAsync();
       
    }
}
