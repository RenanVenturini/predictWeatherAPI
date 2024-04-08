using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Services
{
    public class MedidorDeChuvaService : IMedidorDeChuvaService
    {
        private readonly IMedidorDeChuvaRepository _medidorDeChuvaRepository;

        public MedidorDeChuvaService(IMedidorDeChuvaRepository medidorDeChuvaRepository)
        {
            _medidorDeChuvaRepository = medidorDeChuvaRepository;
        }

        public async Task<MedicaoChuvaResponse> ObterMedicaoChuvaAsync(int dispositivoId)
        {
            var ultimaMedicao = await _medidorDeChuvaRepository.ObterUltimaMedicaoChuvaAsync(dispositivoId);

            if (ultimaMedicao == null)
            {
                throw new Exception("Nenhuma medição de chuva encontrada para o dispositivo");
            }

            var medicaoChuvaResponse = new MedicaoChuvaResponse
            {
                DataHora = ultimaMedicao.DataHora,
                VolumetriaChuva = ultimaMedicao.VolumetriaChuva,
                DispositivoId = ultimaMedicao.DispositivoId
            };

            return medicaoChuvaResponse;
        }
    }
}
