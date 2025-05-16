using System.Reflection.Metadata.Ecma335;
using AgendamentoAPI.Interface;
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
        public async Task<ActionResult> CriarServico(TipoServico servico)
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

        [HttpPut("AtualizarServiço")]

        public async Task<ActionResult> AtualizarServico (TipoServico servico)
        {
            _ServicoRepository.Alterar(servico);
            if (await _ServicoRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Serviço atualizado com sucesso"
                });
            }
            return BadRequest(new
            {
                success = false,
                message = "Erro ao atualizar o serviço"
            });
        }


        [HttpDelete("DeletarServiço)")]
        public async Task<ActionResult> DeletarServico(Guid id)
        {
            _ServicoRepository.Excluir(id);
            if (await _ServicoRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Serviço excluído com sucesso"
                });
            }

            return BadRequest(new
            {
                success = false,
                message = "Erro ao excluir o serviço"
            });
        }
    }
}

