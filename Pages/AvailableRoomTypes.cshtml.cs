using HotelBookingSystem.Models;
using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace HotelBookingSystem.Pages
{
    public class AvailableRoomTypesModel : PageModel
    {
        private BookingServices services;

        [BindProperty]
        public string ChosenRoomTypes { get; set; } = "[]";

        public IEnumerable<BookingAvailableRooms> AvailableRoomsGroupedByType { get; set; } = new List<BookingAvailableRooms>();

        public AvailableRoomTypesModel(BookingServices services)
        {
            this.services = services;
        }


        public void OnGet(DateTime checkIn, DateTime CheckOut)
        {
            //var duration = JsonConvert.DeserializeObject<BookingDuration>(HttpContext.Session.GetString("BookingDuration"));
            AvailableRoomsGroupedByType = services.GetBookingAvailableRoomTypes(checkIn, CheckOut);
        }
        public RedirectToPageResult OnPost()
        {
            return RedirectToPage("Booking", new { ChosenRoomTypes });
        }
    }
}
