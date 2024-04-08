namespace PredictWeatherAPI.Data.Table
{
    public class TbDispositivo
    {
        public int DispositivoId { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string ComandosDisponiveis { get; set; }
        public virtual IEnumerable<TbMedicaoChuva> MedidorChuva { get; set; }
    }
}
