using DjecijiKutakAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DjecijiKutakAPI.Configuration
{
    public class VideoConfiguration : BaseEntityConfiguration<Video>
    {
        public override void Configure(EntityTypeBuilder<Video> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).IsRequired(true);

            builder.HasMany(x => x.Favorites)
                .WithOne(x => x.Video)
                .HasForeignKey(x => x.VideoId);

        }
    }
}
