using PredictWeatherAPI.Data.Table;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Response
{
    public class MedicaoChuvaResponse
    {
        public int MedicaoId { get; set; }

        public int DispositivoId { get; set; }

        public TbDispositivo Dispositivo { get; set; }

        public DateTime DataHora { get; set; }

        public decimal VolumetriaChuva { get; set; }
    }
}