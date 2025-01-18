using Cronos;
using Megapix.Interfaces.IServices;
using Megapix.Services;
using System;

namespace Megapix.Workers
{
    public class CountryServiceWorker(string jobName,
                                      string cronExpression,
                                      ILogger<CountryServiceWorker> logger,
                                      IServiceProvider serviceProvider) : BackgroundService
    {
        private readonly CronExpression expression = CronExpression.Parse(cronExpression);
        private readonly TimeZoneInfo timeZoneInfo = TimeZoneInfo.Local;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {

                    logger.LogInformation($"Executing {jobName} at {DateTime.UtcNow}");

                    using var scope = serviceProvider.CreateScope();
                    var countryService = scope.ServiceProvider.GetRequiredService<ICountryService>();
                    await countryService.GetAndAddAsync(stoppingToken);

                    DateTimeOffset now = DateTimeOffset.Now;
                    var next = expression.GetNextOccurrence(now, timeZoneInfo)!;
                    var delay = next.Value - now;
                    await Task.Delay(delay, stoppingToken);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error in CountryServiceWorker");
                }
            }
        }
    }
}
