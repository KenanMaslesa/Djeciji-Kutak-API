using DjecijiKutakAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired(true);
            builder.Property(p => p.LastName).IsRequired(true);
            builder.Property(p => p.Email).IsRequired(true);
            builder.Property(p => p.Password).IsRequired(true);
            builder.Property(p => p.Address).IsRequired(true);
            builder.Property(p => p.IsAdmin);

            builder
                 .HasMany(f => f.Favorites)
                 .WithOne(u => u.User)
                 .HasForeignKey(u => u.UserId);

            builder
                .HasOne(x => x.Payment)
                .WithOne(x => x.User)
                .HasForeignKey<Payment>(x => x.Id);
          

        }
    }
}
