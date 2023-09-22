using AutoMapper;
using UsuarioApi.Data.DTOs;
using UsuarioApi.Models;

namespace UsuarioApi.Profiles
{
    public class UsuarioProfile: Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
        }
    }
}
