using AgendamentoAPI.Models;


namespace AgendamentoAPI.Infraestutura
{
    public class InfraRepository : IRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(_ProfissionaisController profissionais)
        {
            co.Profissionais.Add(profissionais);
            _supabase.SaveChanges();
        }

        public List<_ProfissionaisController> Get()
        {
            return _supabase.Profissionais.ToList();
        }
    }
}


