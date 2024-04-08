using Microsoft.AspNetCore.Mvc;
using PredictWeatherAPI.Models.Response;
using PredictWeatherAPI.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using PredictWeatherAPI.Data.Interfaces;

namespace PredictWeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedidorDeChuvaController : ControllerBase
    {
        private readonly DispositivoService _dispositivoService;
        private readonly IMedidorDeChuvaService _medidorDeChuvaService;

        public MedidorDeChuvaController(DispositivoService dispositivoService, IMedidorDeChuvaService medidorDeChuvaService)
        {
            _dispositivoService = dispositivoService;
            _medidorDeChuvaService = medidorDeChuvaService;
        }

        [HttpGet("obter-medicao-chuva/{id}")]
        public async Task<IActionResult> ObterMedicaoChuva(int id)
        {
            var dispositivo = await _dispositivoService.ObterDispositivoAsync(id);

            if (dispositivo == null)
            {
                return NotFound("Dispositivo não encontrado");
            }

            // Verifica se o dispositivo atende aos requisitos para medição de chuva
            if (dispositivo.Fabricante != "PredictWeather" || !dispositivo.ComandosDisponiveis.Contains("get_rainfall_intensity"))
            {
                return BadRequest("O dispositivo não atende aos requisitos para medição de chuva");
            }

            // Busca a medição de chuva mais recente para o dispositivo
            var medicaoChuva = await _medidorDeChuvaService.ObterMedicaoChuvaAsync(id);

            if (medicaoChuva == null)
            {
                return NotFound("Nenhuma medição de chuva encontrada para o dispositivo");
            }

            return Ok(medicaoChuva);
        }
    }
}
