using System;

namespace DelegateAndEvents;

public class Subscriber
{
    public void OnPublisherChange(object sender, string message)
    {
        Console.WriteLine($"Event triggered from {sender.GetType().Name} and message is {message}");
    }
}
