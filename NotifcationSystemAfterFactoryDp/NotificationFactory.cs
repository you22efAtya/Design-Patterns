using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationSystemAfterFactoryDp
{
    internal class NotificationFactory
    {
        public static INotifcation CreateNotification(string type)
        {
            if(type.ToLower() == "email")
            {
                return new EmailNotification();
            }
            else if(type.ToLower() == "sms")
            {
                return new SmsNotification();
            }
            else
            {
                throw new ArgumentException("Invalid notification type.");
            }
        }
    }
}
