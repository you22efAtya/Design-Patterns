using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAfterAdapter
{
    internal class LocalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount, string currency)
        {
            Console.WriteLine($"Processing local payment of {amount} {currency}");
        }
    }
}
