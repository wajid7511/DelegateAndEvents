namespace DelegateAndEvents;

public class Publisher
{
    public event EventHandler<string>? OnChange;

    public void Change()
    {
        OnChange?.Invoke(this, "I have Invoke the message");
    }
}
