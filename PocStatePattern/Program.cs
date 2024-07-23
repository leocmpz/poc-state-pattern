using PocStatePattern;

var order = new Order();

Console.WriteLine(order.State);

await order.ReleaseOrder();

Console.WriteLine(order.State);

await order.FinishOrder();

Console.WriteLine(order.State);