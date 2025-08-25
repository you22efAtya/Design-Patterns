using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAfterAdapter
{
    internal class ThirdPartyPaymentAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentGateway thirdPartyPaymentGateway;
        public ThirdPartyPaymentAdapter(ThirdPartyPaymentGateway thirdPartyPaymentGateway)
        {
            this.thirdPartyPaymentGateway = thirdPartyPaymentGateway;
        }
        public void ProcessPayment(decimal amount, string currency)
        {
            // Adapt the method call to the third-party gateway's method
            thirdPartyPaymentGateway.MakePayment(amount, currency);
        }
    }
}
