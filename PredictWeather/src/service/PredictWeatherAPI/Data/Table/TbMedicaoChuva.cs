namespace PredictWeatherAPI.Data.Table
{
    public class TbMedicaoChuva
    {
        public int MedicaoId { get; set; }
        public int DispositivoId { get; set; }
        public DateTime DataHora { get; set; }
        public decimal VolumetriaChuva { get; set; }
        public virtual TbDispositivo Dispositivo { get; set; }
    }
}
