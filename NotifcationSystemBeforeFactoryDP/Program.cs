namespace NotifcationSystemBeforeFactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter notification type (sms/email): ");
            var notificationType = Console.ReadLine();
            Console.WriteLine("Enter message to send: ");
            var message = Console.ReadLine();
            if(notificationType.ToLower() == "email")
            {
                var emailNotification = new EmailNotification();
                emailNotification.Notify(message);
            }
            else if(notificationType.ToLower() == "sms")
            {
                var smsNotification = new SmsNotification();
                smsNotification.Notify(message);
            }
            else
            {
                Console.WriteLine("Invalid notification type.");
            }
        }
    }
}
