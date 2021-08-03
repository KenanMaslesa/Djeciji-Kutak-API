using DjecijiKutakAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Configuration
{
    public class PaymentConfiguration : BaseEntityConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SubscriptionID).IsRequired(true);

            builder.HasOne(x => x.User)
                .WithOne(x => x.Payment)
                .HasForeignKey<Payment>(x => x.UserID);
        }
    }
}
