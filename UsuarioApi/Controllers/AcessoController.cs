using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioApi.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class AcessoController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "IdadeMinima")]
        public IActionResult acesso() {
            return Ok("Sucesso");
        }

    }
}
