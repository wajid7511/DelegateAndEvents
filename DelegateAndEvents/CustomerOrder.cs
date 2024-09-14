public class CustomerOrder
{
    public int OrderNumber { get; private set; }

    public delegate void CustomerOrderFirstOrderDelegate(int orderNumber);
    public event Action? OrderMessageEvent;

    public event CustomerOrderFirstOrderDelegate? FirstOrderDelete;
    public event CustomerOrderFirstOrderDelegate? SilverOrderDelete;
    public event CustomerOrderFirstOrderDelegate? VipOrderDelete;

    public void PlaceOrder(int orderNumber)
    {
        this.OrderNumber = orderNumber;
        OrderMessageEvent?.Invoke();
        Console.WriteLine($"Order Number {orderNumber} is Recieved");
        if (OrderNumber == 1)
        {
            FirstOrderDelete?.Invoke(orderNumber);
        }
        if (OrderNumber == 2)
        {
            SilverOrderDelete?.Invoke(orderNumber);
        }
        if (OrderNumber == 3)
        {
            VipOrderDelete?.Invoke(orderNumber);
        }
    }

}