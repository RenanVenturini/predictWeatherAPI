using System.ComponentModel.DataAnnotations;

namespace PredictWeatherAPI.Data.Table
{
    public class TbUsuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

    }
}
