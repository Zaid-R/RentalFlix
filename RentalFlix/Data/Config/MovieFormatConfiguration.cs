using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalFlix.Entities;

namespace RentalFlix.Data.Config
{
    internal class MovieFormatConfiguration : IEntityTypeConfiguration<MovieFormat>
    {
        public void Configure(EntityTypeBuilder<MovieFormat> builder)
        {
            builder.HasMany(mf => mf.Rentals)
                .WithOne(r => r.MovieFormat)
                .HasForeignKey(r => r.MovieFormatID);
        }
    }
}
