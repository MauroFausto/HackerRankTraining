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
                // Dinamizar a atribui��o do caminho do m�todo que est� em execu��o - diret�rio
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                

                _logger.LogInformation("Por favor, insira um n�mero correspondente ao m�dulo de algoritmos que deseja carregar.");

                

                await Task.Delay(1000);                
            }
        }
    }
}