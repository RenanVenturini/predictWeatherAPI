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
            CreateMap<UsuarioRequest, TbUsuario>();
            CreateMap<TbUsuario, UsuarioResponse>();
            CreateMap<AtualizarDispositivoRequest, TbDispositivo>();
            CreateMap<DispositivoRequest, TbDispositivo>();
            CreateMap<TbDispositivo, DispositivoResponse>();
            CreateMap<TbMedicaoChuva, MedicaoChuvaResponse>();
        }
    }
}
