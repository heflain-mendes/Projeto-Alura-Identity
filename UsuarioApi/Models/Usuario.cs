using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UsuarioApi.Models
{

    public class Usuario: IdentityUser
    {
        public Usuario() : base() { }

        [Required]
        public object DataNascimento { get; internal set; }
    }
}
