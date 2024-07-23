namespace PocStatePattern;

public class Order
{
    public Order()
    {
        State = new Draft();
    }

    public IState State { get; private set; }

    public void SetState(IState state)
    {
        State = state; 
    }

    public async Task ReleaseOrder() => await State.Release(this);
    public async Task FinishOrder() => await State.Finish(this);
}
