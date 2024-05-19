namespace BookStore.BL.BookProducerService;

public class HostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    { 
        return Task.CompletedTask; 
    }
    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
