using System.Reflection;
using System.Text;
using System.IO;

namespace HackerRankService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Dinamizar a atribuição do caminho do método que está em execução - diretório
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                

                _logger.LogInformation("Por favor, insira um número correspondente ao módulo de algoritmos que deseja carregar.");

                

                await Task.Delay(1000);                
            }
        }
    }
}