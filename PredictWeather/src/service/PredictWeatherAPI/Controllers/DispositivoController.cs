using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PredictWeatherAPI.Data;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;
using System.Reflection.Metadata.Ecma335;

namespace PredictWeatherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DispositivoController : ControllerBase
    {
        private readonly IDispositivoService _dispositivoService;

        public DispositivoController(IDispositivoService dispositivoService)
        {
            _dispositivoService = dispositivoService;
        }

        [HttpPost("CriarDispositivo")]
        public async Task<IActionResult> CriarDispositivoAsync(DispositivoRequest dispositivoRrequest)
        {
            await _dispositivoService.CriarDispositivoAsync(dispositivoRrequest);
            return StatusCode(StatusCodes.Status201Created);

            //return CreatedAtAction(nameof(GetDispositivo), new { id = dispositivo.DispositivoId }, dispositivo);
        }

        [HttpGet("ListarDispositivo")]
        public async Task<IActionResult> ListarDispositivoAsync()
        {
            return Ok(await _dispositivoService.ListarDispositivoAsync());
        }

        [HttpGet("{id}/ObterDispositivo")]
        public async Task<IActionResult> ObterDispositivoAsync(int id)
        {
            var dispositivo = await _dispositivoService.ObterDispositivoAsync(id);

            if (dispositivo == null)
            {
                return NotFound();
            }

            return Ok(dispositivo);
        }

        [HttpPut("atualizar")]
        public async Task<IActionResult> AtualizarDispositivoAsync(AtualizarDispositivoRequest request)
        {
            await _dispositivoService.AtualizarDispositivoAsync(request);

            return StatusCode(StatusCodes.Status200OK);
        }

        

        [HttpDelete("{id}/deletar")]
        public async Task<IActionResult> DeleteDispositivo(int id)
        {
            await _dispositivoService.DeletarDispositivoAsync(id);
            return NoContent();
        }
    }
}
