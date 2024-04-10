using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Configuração do servidor Telnet
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); // Endereço IP local
        int port = 23; // Porta padrão Telnet

        // Criação do listener TCP
        TcpListener server = new TcpListener(ipAddress, port);
        server.Start();
        Console.WriteLine("Servidor Telnet iniciado...");

        while (true)
        {
            // Aguarda uma conexão
            TcpClient client = await server.AcceptTcpClientAsync();
            Console.WriteLine("Cliente conectado!");

            try
            {
                // Stream de leitura/escrita para comunicação com o cliente
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };

                // Loop para receber e processar comandos do cliente
                while (true)
                {
                    // Aguarda a entrada do cliente
                    var comando = await reader.ReadLineAsync();

                    // Processa o comando
                    if (comando == "get_rainfall_intensity")
                    {
                        // Simula uma medição de chuva aleatória (para fins de teste)
                        double medicao = new Random().NextDouble() * 100; // Simula uma medição entre 0 e 100 mm/h
                        await writer.WriteLineAsync(medicao.ToString());
                    }
                    else if (comando == "exit")
                    {
                        // Encerra a conexão
                        await writer.WriteLineAsync("Desconectando...");
                        client.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar cliente: {ex.Message}");
            }
        }
    }
}
