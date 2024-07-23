namespace PocStatePattern;

public interface IState
{
    Task Release(Order order);
    Task Finish(Order order);
}
