using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HackerRankService.Algorithms
{
    
    public class AlgorithmsWarmup
    {
        private readonly ILogger<AlgorithmsWarmup> _algLogger;

        public AlgorithmsWarmup(ILogger<AlgorithmsWarmup> algLogger)
        {
            _algLogger = algLogger;
        }

        public async Task ExecuteClass(CancellationToken stoppingToken)
        { 
            _algLogger.LogInformation(
                "Worker running at: {time}. Main program call to: {invokedClass}", 
                DateTimeOffset.Now, 
                this.GetType().Name
            );

            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());

            int sum = SumTwoNumbers(firstValue, secondValue);

            Console.WriteLine($"The sum of this two values is: {sum}.");             
        }

        public static int SumTwoNumbers(int a, int b)
        {
            return a + b; 
        }

    }
}
