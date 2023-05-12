using UsuariosApi.Dtos;

namespace UsuariosApi.Services
{
    public interface IUserService
    {
        public Task Create(UsuarioDto request);
    }
}
