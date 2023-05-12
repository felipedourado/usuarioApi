using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UserService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Create(UsuarioDto request)
        {
            var usuario = _mapper.Map<Usuario>(request);

            var result = await _userManager.CreateAsync(usuario, request.Password);

            if (!result.Succeeded) { throw new ApplicationException("Falha no cadastro do usuário!"); }
        }
    }
}
