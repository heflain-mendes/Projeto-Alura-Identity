using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuarioApi.Models;

namespace UsuarioApi
{
    public class UsuarioDbContext: IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> opts): base(opts){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Usuario>().Property(props => props.DataNascimento).HasColumnType("timestamp without time zone");
        }
    }
}
