using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalFlix.Entities;
using System.Reflection.Emit;

namespace RentalFlix.Data.Config
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasMany(m => m.MovieFormats)
                .WithOne(mf => mf.Movie)
                .HasForeignKey(mf => mf.MovieID);
        }
    }
}
