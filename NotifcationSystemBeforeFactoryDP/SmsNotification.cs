using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationSystemBeforeFactoryDP
{
    internal class SmsNotification
    {
        public void Notify(string message) => Console.WriteLine($"SMS Notification: {message}");
    }
}
