using DjecijiKutakAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Configuration
{
    public class FavoriteConfiguration : BaseEntityConfiguration<Favorite>
    {
        public override void Configure(EntityTypeBuilder<Favorite> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserId).IsRequired(true);
            builder.Property(p => p.VideoId).IsRequired(true);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Favorites)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Video)
              .WithMany(x => x.Favorites)
              .HasForeignKey(x => x.VideoId);

        }
    }
}
