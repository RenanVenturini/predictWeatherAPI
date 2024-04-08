using AutoMapper;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Exception;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Services
{
    public class MedidorChuvaService : IMedidorChuvaService
    {
        private readonly IMedidorChuvaRepository _medidorDeChuvaRepository;
        private readonly IMapper _mapper;

        public MedidorChuvaService(IMedidorChuvaRepository medidorDeChuvaRepository, IMapper mapper)
        {
            _medidorDeChuvaRepository = medidorDeChuvaRepository;
            _mapper = mapper;
        }

        public async Task AdicionarMedicaoChuvaAsync(MedicaoChuvaRequest medicaoChuvaRequest)
        {
            var medidorChuva = _mapper.Map<TbMedicaoChuva>(medicaoChuvaRequest);
            await _medidorDeChuvaRepository.AdicionarMedicaoChuvaAsync(medidorChuva);
        }
        public async Task<IEnumerable<MedicaoChuvaResponse>> ListarMedicaoChuvaAsync(int dispositivoId)
        {
            var medidorChuva = await _medidorDeChuvaRepository.ListarMedicaoChuvaAsync(dispositivoId);

            return _mapper.Map<IEnumerable<MedicaoChuvaResponse>>(medidorChuva);
        }
        public async Task<MedicaoChuvaResponse> ObterUltimaMedicaoChuvaAsync(int dispositivoId)
        {
            var medidorChuva = await _medidorDeChuvaRepository.ObterUltimaMedicaoChuvaAsync(dispositivoId);

            if (medidorChuva == null)
                throw new NotFoundException("Nenhuma medição encontrada!");

            return _mapper.Map<MedicaoChuvaResponse>(medidorChuva);
        }
    }
}
