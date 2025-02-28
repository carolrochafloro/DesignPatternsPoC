using Factory.Interfaces;

namespace Factory.Entities;
public class EmailNotification : INotification
{
    internal EmailNotification() { }
    public void Send()
    {
        Console.WriteLine("Email notification sent!");
        Console.ReadLine();

    }
}
