using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Models.Request
{
    public class DispositivoRequest
    {
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Comando { get; set; }
        public string EnderecoIP { get; set; }
        public int Porta { get; set; }
    }
}
