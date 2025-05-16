using AgendamentoAPI.Context;
using AgendamentoAPI.Interface;
using Microsoft.EntityFrameworkCore;


namespace AgendamentoAPI.Repository
{
    public class ClienteRepositorio : IClienteRepository
    {
        private readonly ApiContext _Context;

        public ClienteRepositorio(ApiContext context)
        {
            _Context = context;
        }

        public void Criar(Cliente cliente)
        {
             _Context.Clientes.Add(cliente);
        }

        public void Deletar(Guid id)
        {
            _Context.Clientes.Remove(new Cliente { Id = id });
        }

        public void Editar(Cliente cliente)
        {
            _Context.Clientes.Update(cliente);
        }

        public Task<Cliente> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
          return await _Context.Clientes.ToListAsync();
           
        }

        public async Task<bool> SaveAllChangesAsync()
        {
         return await _Context.SaveChangesAsync() > 0 ;
        }
    }
}
