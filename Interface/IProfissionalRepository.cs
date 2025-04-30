namespace AgendamentoAPI.Interface
{
    public interface IProfissionalRepository
    {
        void Incluir(Profissional profissional);
        void Alterar(Profissional profissional);
        void Excluir(int id);

        Task<Profissional> SelecionarByPk(int id);
        Task<IEnumerable<Profissional>> SelecionarTodos();

        Task<bool>SaveAllChangesAsync();

    }
}
