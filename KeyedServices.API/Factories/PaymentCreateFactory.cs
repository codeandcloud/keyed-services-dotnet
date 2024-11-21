using KeyedServices.API.DTO;

namespace KeyedServices.API.Factories;

public class PaymentCreateFactory
{
    private static readonly string[] paymentMethods = [
        "PayPal", "Stripe", "CreditCard", "BankTransfer"
    ];

    public static Payment CreatePayment() => new Payment
    (
        $"data-{DateTime.Now.Ticks}",
        paymentMethods[Random.Shared.Next(paymentMethods.Length)]
    );

    public static List<Payment> CreatePayments(int numberOfPayments)
    {
        var ticks = DateTime.Now.Ticks;
        var payments = Enumerable.Range(1, numberOfPayments).Select(index =>
        new Payment
        (
            $"data-{ticks}-{index}",
            paymentMethods[Random.Shared.Next(paymentMethods.Length)]
        ))
        .ToList();
        return payments;
    }

}
