namespace HotelBookingSystem.Services
{
    public record ReservationInfo
    {
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }
        
    }
}
