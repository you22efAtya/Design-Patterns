using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationSystemBeforeFactoryDP
{
    internal class EmailNotification
    {
        public void Notify(string message) => Console.WriteLine($"Email Notification: {message}");
    }
}
