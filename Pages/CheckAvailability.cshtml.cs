using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HotelBookingSystem.Pages
{
    public class CheckAvailabilityModel : PageModel
    {
        [BindProperty]
        public BookingDuration? BookingDuration { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string jsonBookingDuration = JsonConvert.SerializeObject(BookingDuration);
            HttpContext.Session.SetString("BookingDuration", jsonBookingDuration);
            var x = HttpContext.Session.GetString("BookingDuration");
            return RedirectToPage("AvailableRoomTypes", BookingDuration);
        }
    }
}
