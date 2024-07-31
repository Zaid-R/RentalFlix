namespace RentalFlix.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Status { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }

}
