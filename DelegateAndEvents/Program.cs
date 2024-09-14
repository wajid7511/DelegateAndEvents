
static void SubscribeToDelegateAndEvenet(CustomerOrder customerOrder)
{
    customerOrder.OrderMessageEvent += PrintMessage;

    customerOrder.FirstOrderDelete += FirstOrderDelegate;
    customerOrder.SilverOrderDelete += SileverOrderDelegate;
    customerOrder.VipOrderDelete += VipOrderDelegate;
}

static void UnSubscribeToDelegateAndEvenet(CustomerOrder customerOrder)
{
    customerOrder.OrderMessageEvent -= PrintMessage;
    customerOrder.FirstOrderDelete -= FirstOrderDelegate;
    customerOrder.SilverOrderDelete -= SileverOrderDelegate;
    customerOrder.VipOrderDelete -= VipOrderDelegate;
}
static void PrintMessage()
{
    Console.WriteLine("Order Number is Recieved");
}

static void FirstOrderDelegate(int orderNumber)
{
    Console.WriteLine($"Congratulations on your {orderNumber} order!!!!");
}

static void SileverOrderDelegate(int orderNumber)
{
    Console.WriteLine($"Congratulations on your {orderNumber} order you became Silver Memeber now!!!!");
}
static void VipOrderDelegate(int orderNumber)
{
    Console.WriteLine($"Congratulations on your {orderNumber} order you became VIP Memeber now!!!!");
}



CustomerOrder customerOrder = new();
SubscribeToDelegateAndEvenet(customerOrder);


customerOrder.PlaceOrder(1);

Thread.Sleep(1000);
customerOrder.PlaceOrder(2);
Thread.Sleep(1000);
customerOrder.PlaceOrder(3);

UnSubscribeToDelegateAndEvenet(customerOrder);

