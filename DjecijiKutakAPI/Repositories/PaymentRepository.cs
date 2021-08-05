using DjecijiKutakAPI.Data;
using DjecijiKutakAPI.DTOs;
using DjecijiKutakAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly StoreContext _dbContext;

        public PaymentRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PaymentDto> AddPayment(PaymentDto payment, CancellationToken cancellationToken = default)
        {
            var newPayment = new Payment
            {
                UserID = payment.UserId,
                CreatedAt = DateTime.Now,
                SubscriptionID = payment.SubscriptionID,
                BillingToken = payment.BillingToken,
                PaymentID = payment.PaymentID,
                FacilitatorAccessToken = payment.FacilitatorAccessToken,
                OrderID = payment.OrderID
            };
            await _dbContext.Payments.AddAsync(newPayment, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return new PaymentDto(newPayment);
        }
    }
}
