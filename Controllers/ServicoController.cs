using System.Reflection.Metadata.Ecma335;
using AgendamentoAPI.Interface;
using AgendamentoAPI.Migrations;
using AgendamentoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoAPI.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoRepository _ServicoRepository;

        public ServicoController(IServicoRepository servicoRepository)
        {
            _ServicoRepository = servicoRepository;
        }

        [HttpGet("BuscarServico")]
        public async Task<ActionResult<IEnumerable<TipoServico>>> GetServicos()
        {
            return Ok(await _ServicoRepository.SelecionarTodos());
        }

        [HttpPost("CriarServiço")]
        public async Task<ActionResult> CriarServico(Servico servico)
        {
            _ServicoRepository.Incluir(servico); 
            if (await _ServicoRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Cliente atualizado com sucesso",
                    ServicoId = servico.Id
                });
            }

            return BadRequest(new
            {
                success = false,
                message = "Erro ao criar o serviço"
            });
        }
    }
}
