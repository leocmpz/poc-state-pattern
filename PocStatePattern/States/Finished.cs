
namespace PocStatePattern;

public class Finished : IState
{
    public Task Release(Order order)
    {
        throw new NotImplementedException();
    }

    public Task Send(Order order)
    {
        throw new NotImplementedException();
    }

    public Task Finish(Order order)
    {
        throw new NotImplementedException();
    }
}
