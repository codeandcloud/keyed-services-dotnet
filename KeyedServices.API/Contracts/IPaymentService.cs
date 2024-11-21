namespace KeyedServices.API.Contracts;

public interface IPaymentService
{
    void ProcessPayment(string data);
}
