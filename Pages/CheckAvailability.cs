using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages
{
    public class CheckAvailabilityModel : PageModel
    {
        [BindProperty]
        public ReservationInfo? ReservationInfo { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("ReservationResult", ReservationInfo);
        }
    }
}
