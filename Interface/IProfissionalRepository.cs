using AgendamentoAPI.Models;
namespace AgendamentoAPI.Interface
{
    public interface IProfissionalRepository
    {
        Task Incluir(profissionais profissional);
        Task Alterar(profissionais profissional);
        Task Excluir(profissionais profissionais);
        Task<profissionais> SelecionarByPk(int id);
        Task<IEnumerable<profissionais>> SelecionarTodos();
      
    }
}
