using AgendamentoAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]



    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
        [HttpGet("Buscar")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await clienteRepository.ObterTodos());
        }
        [HttpPost("Cadastrar")]
        public async Task<ActionResult> CadastrarCliente(Cliente cliente)
        {
            clienteRepository.Criar(cliente);
            if (await clienteRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Cliente cadastrado com sucesso",
                    clienteId = cliente.Id
                });
            }
            return BadRequest("Erro ao cadastrar cliente");
        }

        [HttpPut("AtualizarCliente")]
        public async Task<ActionResult> AtualizarCliente(Cliente cliente)
        {
            clienteRepository.Editar(cliente);
            if (await clienteRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Cliente atualizado com sucesso",
                    clienteId = cliente.Id
                });
            }
            return BadRequest("Erro ao atualizar cliente");
        }

        [HttpDelete("DeletarCliente")]
        public async Task<ActionResult> DeletarCliente(int id)
        {
            clienteRepository.Deletar(id);
            if (await clienteRepository.SaveAllChangesAsync())
            {
                return Ok(new
                {
                    success = true,
                    message = "Cliente deletado com sucesso",
                    clienteId = id
                });
            }
            return BadRequest("Erro ao deletar cliente");
        }
    }



}

