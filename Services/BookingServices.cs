using HotelBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Services
{
    public class BookingServices
    {
        private HotelBookingSystemContext db;

        public BookingServices(HotelBookingSystemContext db)
        {
            this.db = db;
        }
        public IEnumerable<BookingAvailableRooms> GetBookingAvailableRoomTypes(DateTime checkIn, DateTime checkOut)
        {
            var availableRooms = GetAvailableRoomsWithin(checkIn, checkOut);
            var availableRoomsGroupedByType = availableRooms.GroupBy(r => r.RoomTypeId)
                                                .Select(group => new BookingAvailableRooms
                                                {
                                                    roomType = group.First().RoomType,
                                                    numOfAvailableRooms = group.Count()
                                                });
            return availableRoomsGroupedByType;
        }
        public int calculateNumOfRoomsNeeded(int numOfAdults, int numOfChildren, int maxAdultsPerRoom, int maxChildrenPerRoom)
        {
            var numOfRoomsForChildren = (numOfChildren % maxChildrenPerRoom == 0)
                ? numOfChildren / maxChildrenPerRoom
                : (numOfChildren / maxChildrenPerRoom) + 1;

            var numOfRoomsForAdults = (numOfAdults % maxAdultsPerRoom == 0)
                ? numOfAdults / maxAdultsPerRoom
                : (numOfChildren / maxChildrenPerRoom) + 1;
            return Math.Max(numOfRoomsForChildren, numOfRoomsForAdults);
        }
        private IQueryable<Room> GetAvailableRoomsWithin(DateTime checkIn, DateTime checkOut)
        {
            return db.Rooms
                     .Where(x => !x.Bookings.Any(b => 
                                            (checkIn >= b.CheckIn && checkIn < b.CheckOut)
                                             || (checkOut >= b.CheckIn && checkOut < b.CheckOut)));
        }
        
    }
}
