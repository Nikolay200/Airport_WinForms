namespace Library
{
    public class Passenger
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PatronymicName { get; set; }        
        public DateTime DepartureTime { get; set; }
        public FlightType FlightType { get; set; }

    }
}