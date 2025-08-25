using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemBeforeAdapter
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor paymentProcessor;
        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }
        public void Pay(decimal amount, string currency)
        {
            paymentProcessor.ProcessPayment(amount, currency);
        }
    }
}
