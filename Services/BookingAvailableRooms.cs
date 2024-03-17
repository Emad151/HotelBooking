using HotelBookingSystem.Models;

namespace HotelBookingSystem.Services
{
    public record BookingAvailableRooms
    {
        public RoomType roomType;
        public int numOfAvailableRooms;

    }
}
