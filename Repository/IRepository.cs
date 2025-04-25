using AgendamentoAPI.Models;
using AgendamentoAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace AgendamentoAPI.Repository
{
    [ApiController]
    [Route("api/v1/profisionais")]
    public class ProfissionaisController : ControllerBase
    {
        private readonly IRepository _profissionalrepository;

        public ProfissionaisController(IRepository repository)
        {
            _repository = repository??  throw new ArgumentNullException(nameof(repository));

        }

        [HttpPost]

        public IActionResult Add(ProfissionalViewModel profissionalView)
        {
            var profissionais = new ProfissionalViewModel(profissionaisView.Nome, profissionaisView.Telefone, profissionaisView.Areaatuacao, profissionaisView.Especialidade, profissionaisView.Disponibilidade);
            {
               _profissionalrepository.Add(profissionais);
                _profissionalrepository.SaveChanges();
            }
            ;



        }
    }
}
