using HotelBookingSystem.Models;
using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Pages
{
    public class ReservationResultModel : PageModel
    {
        private BookingServices services;

        public IEnumerable<BookingAvailableRooms> AvailableRoomsGroupedByType { get; set; } = new List<BookingAvailableRooms>();

        public ReservationResultModel(BookingServices services)
        {
            this.services = services;
        }
        public void OnGet(DateTime checkIn, DateTime CheckOut)
        {
            AvailableRoomsGroupedByType = services.GetBookingAvailableRoomTypes(checkIn, CheckOut);
        }
    }
}
