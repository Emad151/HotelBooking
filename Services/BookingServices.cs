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
        public void GetDailyAvailableRoomtypes(DateTime checkIn, DateTime checkOut, int numOfAdults, int numOfChildren)
        {
            IEnumerable<object> availableRoomtypes = db.DailyRoomAvailablities
                .Where(x => x.IsAvailable && x.Day >= checkIn && x.Day < checkOut) //all available rooms between checkIn & checkOut
                .Include(x => x.Room)
                .GroupBy(x => x.Day)//each day with all corresponding available rooms
                .Select(dayGroup => new
                {
                    day = dayGroup.Key,
                    groupedRoomTypes = dayGroup
                                        .GroupBy(x => x.Room.RoomTypeId)//groubibing the daily corresponing rooms by the type
                                        .Select(roomTypeIdGroub => new
                                        {
                                              RoomTypeId = roomTypeIdGroub.Key,
                                              numberAvailableRooms = roomTypeIdGroub.Count()
                                        })   
                });
            // TODO: complete this Method

            // TODO: implement calculateNumOfRoomsNeeded
                            
        }
    }
}
