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
            CreateMap<TbMedicaoChuva, MedicaoChuvaResponse>()
                .ForPath(
                    src => src.Dispositivo,
                    opt => opt.MapFrom(dest => dest.Dispositivo.Nome)
                );

            CreateMap<MedicaoChuvaRequest, TbMedicaoChuva>()
                .ForMember(
                    src => src.DataHora,
                    opt => opt.MapFrom(dest => DateTime.Now)
                );
        }
    }
}
