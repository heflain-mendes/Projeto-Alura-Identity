using System.ComponentModel.DataAnnotations;

namespace UsuarioApi.Data.DTOs
{
    public class LoginUsuarioDTO
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
