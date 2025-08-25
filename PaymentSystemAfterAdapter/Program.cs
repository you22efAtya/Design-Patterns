namespace PaymentSystemAfterAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paymentProcessor = new LocalPaymentProcessor();
            PaymentService paymentService = new PaymentService(paymentProcessor);
            ThirdPartyPaymentGateway thirdPartyPaymentGateway = new ThirdPartyPaymentGateway();
            IPaymentProcessor thirdPartyAdapter = new ThirdPartyPaymentAdapter(thirdPartyPaymentGateway);
            paymentService = new PaymentService(thirdPartyAdapter);// Now we can use the adapter for ThirdPartyPaymentGateway
            paymentService.Pay(100, "USD");
        }
    }
}
