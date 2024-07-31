
using Microsoft.EntityFrameworkCore;
namespace RentalFlix.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public float Rating { get; set; }

        public ICollection<MovieFormat> MovieFormats { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
