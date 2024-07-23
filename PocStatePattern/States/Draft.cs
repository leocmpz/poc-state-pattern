
namespace PocStatePattern;

public class Draft : IState
{
    public async Task Release(Order order)
    {
        await Task.Delay(100);
        order.SetState(new Approved());
    }

    public Task Finish(Order order)
    {
        return Task.CompletedTask;
    }
}
