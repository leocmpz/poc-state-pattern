
namespace PocStatePattern;

public class Approved : IState
{
    public Task Release(Order order)
    {
        return Task.CompletedTask;
    }

    public async Task Finish(Order order)
    {
        await Task.Delay(100);
        order.SetState(new Finished());
    }
}
