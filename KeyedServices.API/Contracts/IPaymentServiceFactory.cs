namespace KeyedServices.API.Contracts
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetPaymentService(string paymentType);
    }
}
