namespace RentalFlix.Entities
{
    public class MovieFormat
    {
        public int Id { get; set; }
        public string FormatType { get; set; }
        public int QuantityAvailable { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }

}
