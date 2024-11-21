using KeyedServices.API.Contracts;
using Serilog;

namespace KeyedServices.API.Services;

public class CreditCardService : IPaymentService
{
    public void ProcessPayment(string data) => Log.Information($"[CreditCard] {data}");
}