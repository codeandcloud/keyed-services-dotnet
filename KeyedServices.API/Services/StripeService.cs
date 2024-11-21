using KeyedServices.API.Contracts;
using Serilog;

namespace KeyedServices.API.Services;

public class StripeService : IPaymentService
{
    public void ProcessPayment(string data) => Log.Information($"[Stripe] {data}");
}