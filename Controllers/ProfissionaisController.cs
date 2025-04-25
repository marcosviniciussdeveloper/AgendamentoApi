using AgendamentoAPI.Models;
using AgendamentoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoAPI.Controllers
{
    [ApiController]
    [Route("api/v1/profisionais]")]
    public class ProfissionaisController : ControllerBase
    {
        private readonly IRepository _repository;

        public ProfissionaisController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Add([FromBody] _ProfissionaisController profissionalView)
        {
            if (profissionalView == null)
            {
                return BadRequest("Profissional data is required.");
            }

            var profissionais = new _ProfissionaisController
            {
                Nome = profissionalView.Nome,
                Telefone = profissionalView.Telefone,
                Areaatuacao = profissionalView.Areaatuacao,
                Especialidade = profissionalView.Especialidade,
                Disponibilidade = profissionalView.Disponibilidade
            };

          
            _repository.Add(profissionais);
            _repository.SaveChanges();

            return CreatedAtAction(nameof(Add), new { id = profissionais.Id }, profissionais);
        }
    }
}
