using KeyedServices.API.Contracts;
using KeyedServices.API.Factories;
using KeyedServices.API.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KeyedServices.API.Extensions;
public static class ServiceExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddKeyedTransient<IPaymentService, BankTransferService>("BankTransfer");
        services.AddKeyedTransient<IPaymentService, CreditCardService>("CreditCard");
        services.AddKeyedTransient<IPaymentService, PayPalService>("PayPal");
        services.AddKeyedTransient<IPaymentService, StripeService>("Stripe");

        services.AddTransient<IPaymentServiceFactory, PaymentServiceFactory>();
    }
}
