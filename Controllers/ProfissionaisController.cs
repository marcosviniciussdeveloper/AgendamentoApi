using AgendamentoAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace AgendamentoAPI.Controllers
{
    [ApiController]
    [Route("api/v1/profisionais]")]
    public class ProfissionaisController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetProfissionais()
        {
            var profissionais = await _context.Profissionais.Get();
            return Ok(profissionais);
        }

}