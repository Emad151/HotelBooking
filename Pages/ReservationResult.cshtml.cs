using HotelBookingSystem.Models;
using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Pages
{
    public class ReservationResultModel : PageModel
    {
        private HotelBookingSystemContext db;
        private BookingServices services;

        public IEnumerable<object>? DailyAvailableRoomtypes { get; set; }

        public ReservationResultModel(HotelBookingSystemContext db, BookingServices services)
        {
            this.db = db;
            this.services = services;
        }
        public void OnGet(DateTime checkIn, DateTime CheckOut, int NumberOfChildren, int NumberOfAdults)
        {
            DailyAvailableRoomtypes = services.GetDailyAvailableRoomtypes(checkIn, CheckOut, NumberOfAdults, NumberOfChildren);
        }
    }
}
