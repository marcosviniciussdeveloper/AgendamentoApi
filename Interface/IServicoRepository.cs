namespace AgendamentoAPI.Interface
{
    public interface IServicoRepository
    {
        void Incluir(TipoServico servico);

        void Alterar(TipoServico servico);

        void Excluir(Guid id);

        Task<bool> SaveAllChangesAsync();
        Task<IEnumerable<TipoServico>> SelecionarTodos();




    }
}
