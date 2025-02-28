// See https://aka.ms/new-console-template for more information

using Factory.Enum;
using Factory.Factory;

var notification = NotificationFactory.Create(ENotificationType.SMS);

notification.Send();