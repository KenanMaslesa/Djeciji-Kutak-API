using API.Controllers;
using DjecijiKutakAPI.DTOs;
using DjecijiKutakAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Controllers
{
    public class PaymentController : BaseApiController
    {
        private readonly IUserRepository _usertRepository;
        private readonly IPaymentRepository _paymentRepository;

        public PaymentController(IUserRepository usertRepository, IPaymentRepository paymentRepository)
        {
            _usertRepository = usertRepository;
            _paymentRepository = paymentRepository;
        }

        [HttpPost("add")]
        public async Task<PaymentDto> AddPayment([FromBody] PaymentDto paymentDto)
        {
            return await _paymentRepository.AddPayment(paymentDto);
        }

        [HttpGet("is-payment-successful/{userId}")]
        public bool IsPaymentSuccessful(int userId)
        {
            return _paymentRepository.IsPaymentSuccessful(userId);
        }
    }
}
