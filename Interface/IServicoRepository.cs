namespace AgendamentoAPI.Interface
{
    public interface IServicoRepository
    {
        void Incluir(TipoServico servico);

        void Alterar(TipoServico servico);

        void Excluir(int id);

        Task<bool> SaveAllChangesAsync();
        Task<IEnumerable<TipoServico>> SelecionarTodos();




    }
}
