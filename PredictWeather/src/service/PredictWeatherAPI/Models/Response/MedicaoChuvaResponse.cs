using PredictWeatherAPI.Data.Table;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Response
{
    public class MedicaoChuvaResponse
    {
        public string Dispositivo { get; set; }
        public string VolumetriaChuva { get; set; }
    }
}