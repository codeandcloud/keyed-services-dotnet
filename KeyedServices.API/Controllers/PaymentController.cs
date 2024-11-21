using KeyedServices.API.Contracts;
using KeyedServices.API.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;

namespace KeyedServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;
        public PaymentController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }
        public IActionResult Get()
        {
            var payment = PaymentCreateFactory.CreatePayment();

            var paymentService = _paymentServiceFactory.GetPaymentService(payment.PaymentMethod);
            paymentService.ProcessPayment(payment.Data);

            return Ok("Payment Controller is working");
        }
    }
}
