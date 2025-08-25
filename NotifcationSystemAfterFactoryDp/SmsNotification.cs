using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationSystemAfterFactoryDp
{
    internal class SmsNotification : INotifcation
    {
        public void Notify(string message) => Console.WriteLine($"SMS Notification: {message}");
    }
}
