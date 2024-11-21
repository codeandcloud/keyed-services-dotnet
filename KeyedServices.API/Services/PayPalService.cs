using KeyedServices.API.Contracts;
using Serilog;

namespace KeyedServices.API.Services;

public class PayPalService : IPaymentService
{
    public void ProcessPayment(string data) => Log.Information($"[PayPal] {data}");
}
