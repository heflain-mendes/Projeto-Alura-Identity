using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data.DTOs;
using UsuarioApi.Models;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController: ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario( [FromBody]CreateUsuarioDTO dto)
        {
            IdentityResult result = await _usuarioService.CadastraUsuario(dto);

            if (result.Succeeded) return Ok("Usuário cadastrado");

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUsuarioDTO dto)
        {
            var token = await _usuarioService.Login(dto);

            return Ok(token);
        }
    }
}
