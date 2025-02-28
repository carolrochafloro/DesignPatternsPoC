using Factory.Interfaces;

namespace Factory.Entities;
public class PushNotification : INotification
{
    internal PushNotification() { }
    public void Send()
    {
        Console.WriteLine("Push notification sent!");
        Console.ReadLine();

    }
}
