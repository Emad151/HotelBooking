namespace HotelBookingSystem.Services
{
    public record BookingDuration
    {
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }
        
    }
}
