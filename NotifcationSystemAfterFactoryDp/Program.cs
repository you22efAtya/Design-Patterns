namespace NotifcationSystemAfterFactoryDp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the main program does not need to know about the concrete classes
            Console.WriteLine("Enter notification type (sms/email): ");
            var notificationType = Console.ReadLine();
            Console.WriteLine("Enter message to send: ");

            var message = Console.ReadLine();
            var notification = NotificationFactory.CreateNotification(notificationType);
            notification.Notify(message);
        }
    }
}
