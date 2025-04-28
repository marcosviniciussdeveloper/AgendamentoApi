using AgendamentoAPI.Interface;
using AgendamentoAPI.Models;
using AgendamentoAPI.Services;
namespace AgendamentoAPI.Repository
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly SupabaseService _supabase;

        public ProfissionalRepository(SupabaseService supabase)
        {
            _supabase = supabase;
        }

        public async Task Alterar(profissionais profissional)
        {
            try
            {
                var client = _supabase.GetClient();
                var table = client.From<profissionais>();
                var response = await table
                    .Where(x => x.Id == profissional.Id)
                    .Update(profissional);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar o profissional: " + ex.Message);
            }
        }

        public async Task Incluir(profissionais profissional)
        {
            throw new NotImplementedException();
        }

        public async Task<profissionais> SelecionarByPk(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<profissionais>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(profissionais profissional)
        {
            if (profissional == null || profissional.Id <= 0)
            {
                throw new ArgumentNullException("Profissional inválido ou ID não fornecido.");
            }
            try
            {
                var client = _supabase.GetClient();
                var table = client.From<profissionais>();
                var response = await client
                .Where(x => x.Id == profissional.Id)
                .Delete(profissional);

              
                if (response == null || response.Models.Count == 0)
                {
                    throw new Exception("Nenhum registro foi excluído. Verifique se o ID é válido.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o profissional: " + ex.Message, ex);
            }
        }
    }
}
