using Factory.Entities;
using Factory.Enum;
using Factory.Interfaces;

namespace Factory.Factory;
public static class NotificationFactory
{
    public static INotification Create(ENotificationType type) =>
    type switch
    {
        ENotificationType.Email => new EmailNotification(),
        ENotificationType.Push => new PushNotification(),
        ENotificationType.SMS => new SMSNotification(),
        _ => throw new ArgumentException("Unsupported or invalid type of notification.")
    };
}
