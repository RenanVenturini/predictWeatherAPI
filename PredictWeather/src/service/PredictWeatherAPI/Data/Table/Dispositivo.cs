namespace PredictWeatherAPI.Data.Table
{
    public class Dispositivo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Comando { get; set; }
        public string EnderecoIP { get; set; }
        public int Porta { get; set; }
    }
}
