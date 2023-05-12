using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUserService _userService;

        public UsuarioController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UsuarioDto request)
        {
            await _userService.Create(request);
            return Ok();
        }
    }
}
