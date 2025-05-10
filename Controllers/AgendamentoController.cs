using AgendamentoAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoRepository _AgendamentoRepository;
        public AgendamentoController(IAgendamentoRepository agendamentoRepository)
        {
            _AgendamentoRepository = agendamentoRepository;
        }


        [HttpGet("Buscar")]
        public async Task<ActionResult<IEnumerable<Agendamento>>> GetAgendamentos()
        {
            return Ok(await _AgendamentoRepository.SelecionarTodos());
        }

        [HttpPost("Cadastrar")]
        public async Task<ActionResult> CadastrarAgendamento(Agendamento agendamento)
        {
            _AgendamentoRepository.Incluir(agendamento);
            if (await _AgendamentoRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Agendamento cadastrado com sucesso",
                    agendamentoId = agendamento.Id
                });
            }
            return BadRequest("Erro ao cadastrar agendamento");
        }


        [HttpPut("AtualizarAgendamento")]
        public async Task<ActionResult> AlterarAgendamento(Agendamento agendamento)
        {
            _AgendamentoRepository.Alterar(agendamento);
            if (await _AgendamentoRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Agendamento atualizado com sucesso"
                });
            }
            return BadRequest("Erro ao atualizar agendamento");
        }

        [HttpDelete("DeletarAgendamento")]
        public async Task<ActionResult> DeletarAgendamento(int id)
        {
            _AgendamentoRepository.Excluir(id);
            if (await _AgendamentoRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Agendamento excluído com sucesso"
                });
            }
            return BadRequest("Erro ao excluir agendamento");
        }
    }
}
