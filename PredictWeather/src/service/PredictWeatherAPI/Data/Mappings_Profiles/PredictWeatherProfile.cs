using AutoMapper;
using PredictWeatherAPI.Data.Table;
using PredictWeatherAPI.Models.Request;
using PredictWeatherAPI.Models.Response;

namespace PredictWeatherAPI.Data.Mappings_Profiles
{
    public class PredictWeatherProfile : Profile
    {
        public PredictWeatherProfile()
        {
            CreateMap<UsuarioRequest, Usuario>();
            CreateMap<Usuario, UsuarioResponse>();
            CreateMap<AtualizarDispositivoRequest, Dispositivo>();
            CreateMap<DispositivoRequest, Dispositivo>();
            CreateMap<Dispositivo, DispositivoResponse>();
        }
    }
}
