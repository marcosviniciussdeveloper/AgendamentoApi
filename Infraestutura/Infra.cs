using AgendamentoAPI.Models;
using AgendamentoAPI.Repository;


namespace AgendamentoAPI.Infraestutura
{
    public class Infra : IRepository
    {
        private readonly ConnectionContext _supabase = new ConnectionContext();

        public void Add(_ProfissionaisController profissionais)
        {
            _supabase.Profissionais.Add(profissionais);
            _supabase.SaveChanges();
        }

        public List<_ProfissionaisController> Get()
        {
            return _supabase.Profissionais.ToList();
        }
    }
}


