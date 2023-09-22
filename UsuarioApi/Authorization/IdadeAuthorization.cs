using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsuarioApi.Authorization
{
    public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
        {
            //Nesse ponto context não possui ClaimType.DateOfBirth
            //Mas estou colocando essa Claim em TokenService.cs
            var dataNascimentoCaim = context.User.FindFirst(claim =>
               claim.Type == ClaimTypes.DateOfBirth);

            if (dataNascimentoCaim == null) return Task.CompletedTask;

            var dataNascimento = Convert.ToDateTime(dataNascimentoCaim.Value);

            var idadeUsuario = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento > DateTime.Today.AddYears(-idadeUsuario)) idadeUsuario--;

            if (idadeUsuario > requirement.Idade) context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
