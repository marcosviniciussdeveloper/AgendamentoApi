
using AgendamentoAPI.Interface;
using AgendamentoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Profissionais : ControllerBase
    {

        private readonly IProfissionalRepository _ProfissionalRepository;


        public Profissionais(IProfissionalRepository profissionalRepository)
        {
            _ProfissionalRepository = profissionalRepository;
        }

        [HttpGet("Buscar")]
        public async Task<ActionResult<IEnumerable<Profissional>>> GetProfissionais()
        {
            return Ok(await _ProfissionalRepository.SelecionarTodos());
        }


        [HttpPost("Cadastrar")]
        public async Task<ActionResult> CadastrarProfissional(Profissional profissional)
        {
            _ProfissionalRepository.Incluir(profissional);

            if (await _ProfissionalRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Profissional cadastrado com sucesso",
                    profissionalId = profissional.Id
                });
            }

            return BadRequest("Erro ao cadastrar profissional");
        }


        [HttpPut("AtualizarProfissional")]
        public async Task<ActionResult> AlterarProfissional(Profissional profissional)
        {

            _ProfissionalRepository.Alterar(profissional);
            if (await _ProfissionalRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Profissional atualizado com sucesso"
                });
            }

            return BadRequest("Falha ao atualizar profissional");
        }

        [HttpDelete("DeletarProfissional")]
        public async Task<IActionResult> ExcluirProfissional(int Id)
        {
        
            {
                _ProfissionalRepository.Excluir(Id);
                if (await _ProfissionalRepository.SaveAllChangesAsync())
                {
                    return Ok($"Profissional {Id} excluído com sucesso");
                }

                return BadRequest("Erro ao excluir profissional");
            }
        
        }



    }

}



