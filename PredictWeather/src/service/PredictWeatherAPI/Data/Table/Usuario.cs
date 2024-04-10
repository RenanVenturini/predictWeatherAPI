using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Data.Table
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

    }
}
