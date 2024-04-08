using AutoMapper;
using PredictWeatherAPI.Data.Interfaces;
using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Services
{
    public class DispositivoService : IDispositivoService
    {
        private readonly IDispositivoRepository _dispositivoRepository;
        private readonly IMapper _mapper;

        public DispositivoService(IDispositivoRepository dispositivoRepository, IMapper mapper)
        {
            _dispositivoRepository = dispositivoRepository;
            _mapper = mapper;
        }

        public async Task CriarDispositivoAsync(DispositivoRequest dispositivoRrequest)
        {
            var dispositivo = _mapper.Map<TbDispositivo>(dispositivoRrequest);
            await _dispositivoRepository.AtualizarDispositivoAsync(dispositivo);
        }
        public async Task AtualizarDispositivoAsync(AtualizarDispositivoRequest dispositivoRrequest)
        {
            var dispositivo = _mapper.Map<TbDispositivo>(dispositivoRrequest);
            await _dispositivoRepository.AtualizarDispositivoAsync(dispositivo);
        }
        public async Task<DispositivoResponse> ObterDispositivoAsync(int id)
        {
            var dispositivo =  await _dispositivoRepository.ObterDispositivoAsync(id);
            return _mapper.Map<DispositivoResponse>(dispositivo);
        }
        public async Task DeletarDispositivoAsync(int id)
        {
            var dispositivo = await _dispositivoRepository.ObterDispositivoAsync(id);
            await _dispositivoRepository.DeletarDispositivoAsync(dispositivo);
        }
        public async Task<IEnumerable<DispositivoResponse>> ListarDispositivoAsync()
        {
            var dispositivo = await _dispositivoRepository.ListarDispositivoAsync();
            return _mapper.Map<IEnumerable<DispositivoResponse>>(dispositivo);
        }
    }
}
