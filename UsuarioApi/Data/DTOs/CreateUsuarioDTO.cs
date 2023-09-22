using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsuarioApi.Data.DTOs
{
    public class CreateUsuarioDTO
    {
//      public string Nome { get; set; }
//      public string Sobrenome { get; set; }
//      public string Senha { get; set; }
//      public string Email { get; set; }
//      public string Telefone { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; } = string.Empty;
    }
}
