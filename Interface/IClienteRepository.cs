namespace AgendamentoAPI.Interface
{
    public interface IClienteRepository
    {
     
        void Criar(Cliente cliente);

        void Editar(Cliente cliente);

        void Deletar(int id);

        Task<IEnumerable<Cliente>> ObterTodos();

        Task<bool> SaveAllChangesAsync();





    }
}
