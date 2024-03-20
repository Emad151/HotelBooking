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
        public BookingDuration BookingDuration { get; set; } = new BookingDuration();
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            #region
            //string jsonBookingDuration = JsonConvert.SerializeObject(BookingDuration);
            //HttpContext.Session.SetString("BookingDuration", jsonBookingDuration);
            //var x = HttpContext.Session.GetString("BookingDuration");
            #endregion

            //TODO: if booking duration is null do somthing else
            return RedirectToPage("AvailableRoomTypes", BookingDuration);
        }
    }
}
