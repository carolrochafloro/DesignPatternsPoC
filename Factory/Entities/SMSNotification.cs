using Factory.Interfaces;

namespace Factory.Entities;
public class SMSNotification : INotification
{
    internal SMSNotification() { }
    public void Send()
    {
        Console.WriteLine("SMS notification sent!");
        Console.ReadLine();
    }
}
