using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAfterAdapter
{
    internal class ThirdPartyPaymentGateway
    {
        public void MakePayment(decimal amount, string currency)
        {
            // Simulate payment processing
            Console.WriteLine($"Processing payment of {amount} {currency} through ThirdPartyPaymentGateway.");
        }
    }
}
