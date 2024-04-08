using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Models.Request;

namespace PredictWeatherAPI.Controllers
{
    [ApiController]
    [Authorize]
    public class MedidorChuvaController : ControllerBase
    {
        private readonly IMedidorChuvaService _medidorDeChuvaService;

        public MedidorChuvaController(IMedidorChuvaService medidorDeChuvaService)
        {
            _medidorDeChuvaService = medidorDeChuvaService;
        }

        [HttpPost("medicoes")]
        public async Task<IActionResult> AdicionarMedicaoChuvaAsync(MedicaoChuvaRequest medicaoChuvaRequest)
        {
            await _medidorDeChuvaService.AdicionarMedicaoChuvaAsync(medicaoChuvaRequest);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet("dispositivos/{dispositivoId}/medicoes")]
        public async Task<IActionResult> ListarMedicaoChuvaAsync(int dispositivoId)
        {
            var medidorChuva = await _medidorDeChuvaService.ListarMedicaoChuvaAsync(dispositivoId);
            return Ok(medidorChuva);
        }

        [HttpGet("dispositivos/{dispositivoId}/ultima-medicao")]
        public async Task<IActionResult> ObterUltimaMedicaoChuvaAsync(int dispositivoId)
        {
            var medidorChuva = await _medidorDeChuvaService.ObterUltimaMedicaoChuvaAsync(dispositivoId);

            return Ok(medidorChuva);
        }
    }
}
