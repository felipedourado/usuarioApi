using AutoMapper;
using UsuariosApi.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Mappers
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<UsuarioDto, Usuario>();
        }
    }
}
