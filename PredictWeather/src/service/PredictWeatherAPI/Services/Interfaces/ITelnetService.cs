namespace PredictWeatherAPI.Services.Interfaces
{
    public interface ITelnetService
    {
        Task<string> EnviarComandoAsync(string enderecoIP, int porta, string comando);
    }
}
