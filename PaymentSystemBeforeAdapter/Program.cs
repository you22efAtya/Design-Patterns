namespace PaymentSystemBeforeAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paymentProcessor = new LocalPaymentProcessor();
            PaymentService paymentService = new PaymentService(paymentProcessor);
            ThirdPartyPaymentGateway thirdPartyPaymentGateway = new ThirdPartyPaymentGateway();
            //paymentService = new PaymentService(ThirdPartyPaymentGateway); // Here is the problem the adapter is missing for ThirdPartyPaymentGateway
            paymentService.Pay(100, "USD");
        }
    }
}
