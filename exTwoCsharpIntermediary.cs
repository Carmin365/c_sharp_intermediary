public delegate void MyDelegate(string message);

public class Publisher
{
    public event MyDelegate EventOccurred;

    public void TriggerEvent()
    {
        if (EventOccurred != null)
        {
            EventOccurred("Event trigger!");
        }
    }
}

