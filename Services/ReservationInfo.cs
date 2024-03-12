namespace HotelBookingSystem.Services
{
    public class ReservationInfo
    {
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfAdults { get; set; }
    }
}
