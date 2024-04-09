using Microsoft.AspNetCore.Mvc;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Services.Interfaces;

namespace PredictWeatherAPI.AutenticacaoController
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public AutenticacaoController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest login)
        {
            if (login == null)
                return Unauthorized();

            var usuario = await _usuarioService.AutenticarAsync(login);

            return Ok(usuario);
        }
    }
}
