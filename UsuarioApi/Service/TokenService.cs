using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UsuarioApi.Models;

namespace UsuarioApi.Service
{
    public class TokenService
    {
        private IConfiguration _config;

        public TokenService(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, usuario.UserName ?? throw new Exception("Não foi possivel encontra nome de usuário")),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id),
                new Claim(ClaimTypes.DateOfBirth, usuario.DataNascimento.ToString())
            };

            var symetricSecurityKey = _config["SymmetricSecurityKey"] ?? throw new Exception("Não foi possível obter SymmetricSecurityKey");
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(symetricSecurityKey));

            var signingCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    expires: DateTime.Now.AddHours(8),
                    claims: claims,
                    signingCredentials: signingCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
