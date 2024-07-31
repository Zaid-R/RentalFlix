namespace RentalFlix.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int MovieFormatID { get; set; }
        public MovieFormat MovieFormat { get; set; }
    }

}
