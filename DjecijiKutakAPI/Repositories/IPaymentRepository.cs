using DjecijiKutakAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Repositories
{
    public interface IPaymentRepository
    {
        Task<PaymentDto> AddPayment(PaymentDto payment, CancellationToken cancellationToken = default);
        bool IsPaymentSuccessful(int userId, CancellationToken cancellationToken = default);

    }
}
