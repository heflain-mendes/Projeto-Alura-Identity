using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuarioApi.Data.DTOs;
using UsuarioApi.Models;

namespace UsuarioApi.Service
{

    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<IdentityResult> CadastraUsuario(CreateUsuarioDTO dto)
        {

            Usuario usuario = _mapper.Map<Usuario>(dto);

             return await _userManager.CreateAsync(usuario, dto.Password);
        }

        public async Task<string> Login(LoginUsuarioDTO dto)
        {
            var result =  await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);

            if (!result.Succeeded) throw new Exception("Usario não encontrado");

            var usuario = _signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName == dto.UserName.ToUpper()) ?? throw new Exception("Usuario não encontrado");

            return _tokenService.GenerateToken(usuario);
        }
    }
}
