using KeyedServices.API.Contracts;

namespace KeyedServices.API.Factories
{
public class PaymentServiceFactory: IPaymentServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public PaymentServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IPaymentService GetPaymentService(string paymentType)
    {
        return _serviceProvider.GetRequiredKeyedService<IPaymentService>(paymentType);
    }
}
}
