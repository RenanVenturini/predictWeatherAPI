using PredictWeatherAPI.Services.Interfaces;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PredictWeatherAPI.Services
{
    public class TelnetService : ITelnetService
    {
        public async Task<string> EnviarComandoAsync(string enderecoIP, int porta, string comando)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    await client.ConnectAsync(enderecoIP, porta);

                    using (var stream = client.GetStream())
                    using (var writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true })
                    using (var reader = new StreamReader(stream, Encoding.ASCII))
                    {
                        // Envie o comando Telnet
                        await writer.WriteLineAsync(comando);
                        await writer.FlushAsync();

                        // Aguarde a resposta do dispositivo
                        var resposta = await reader.ReadToEndAsync();

                        return resposta;
                    }
                }
            }
            catch (System.Exception ex)
            {
                // Lidar com exceções de conexão
                throw new System.Exception($"Erro ao enviar comando Telnet: {ex.Message}");
            }
        }
    }

}
