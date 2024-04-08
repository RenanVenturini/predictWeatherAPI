using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Models.Request;

namespace PredictWeatherAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("dispositivos")]
    public class DispositivoController : ControllerBase
    {
        private readonly IDispositivoService _dispositivoService;

        public DispositivoController(IDispositivoService dispositivoService)
        {
            _dispositivoService = dispositivoService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarDispositivoAsync(DispositivoRequest dispositivoRrequest)
        {
            await _dispositivoService.CriarDispositivoAsync(dispositivoRrequest);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public async Task<IActionResult> ListarDispositivoAsync()
        {
            return Ok(await _dispositivoService.ListarDispositivoAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterDispositivoAsync(int id)
        {
            var dispositivo = await _dispositivoService.ObterDispositivoAsync(id);

            return Ok(dispositivo);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarDispositivoAsync(AtualizarDispositivoRequest request)
        {
            await _dispositivoService.AtualizarDispositivoAsync(request);

            return StatusCode(StatusCodes.Status200OK);
        }

        

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDispositivo(int id)
        {
            await _dispositivoService.DeletarDispositivoAsync(id);
            return NoContent();
        }
    }
}
