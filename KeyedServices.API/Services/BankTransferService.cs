using KeyedServices.API.Contracts;
using Serilog;

namespace KeyedServices.API.Services;

public class BankTransferService : IPaymentService
{

    public void ProcessPayment(string data) => Log.Information($"[BanklTransfer] {data}");
}