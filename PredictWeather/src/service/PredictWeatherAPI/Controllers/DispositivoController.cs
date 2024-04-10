using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;
using PredictWeatherAPI.Services.Interfaces;

namespace PredictWeatherAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("device")]
    public class DispositivoController : ControllerBase
    {
        private readonly IDispositivoService _dispositivoService;
        private readonly ITelnetService _telnetService;

        public DispositivoController(IDispositivoService dispositivoService, ITelnetService telnetService)
        {
            _dispositivoService = dispositivoService;
            _telnetService = telnetService;
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
        public async Task<IActionResult> DeleteDispositivoAsync(int id)
        {
            await _dispositivoService.DeletarDispositivoAsync(id);
            return NoContent();
        }

        [HttpGet("medicoes")]
        public async Task<IActionResult> ListarMedicoesAsync()
        {
            try
            {
                var dispositivos = await _dispositivoService.ListarDispositivoAsync();

                var medicoesChuva = new List<MedicaoChuvaResponse>();

                foreach (var dispositivo in dispositivos)
                {
                    var medicao = await _telnetService.EnviarComandoAsync(dispositivo.EnderecoIP, dispositivo.Porta, dispositivo.Comando);
                    medicoesChuva.Add(new MedicaoChuvaResponse { Dispositivo = dispositivo.Nome, VolumetriaChuva = $"{medicao} mm/h" });
                }

                return Ok(medicoesChuva);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error = ex.Message });
            }
        }
    }
}
