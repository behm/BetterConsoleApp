using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleUI
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _logger;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> logger, IConfiguration config)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public void Run()
        {
            var loopCount = _config.GetValue<int>("LoopCount");

            for (int i=0; i<loopCount; i++)
            {
                _logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
