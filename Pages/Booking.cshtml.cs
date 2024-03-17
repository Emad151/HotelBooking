using HotelBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HotelBookingSystem.Pages
{
    public class BookingModel : PageModel
    {

        public List<ChosenRoomType> ChosenRoomTypes {  get; set; }

        public void OnGet(string ChosenRoomTypes)
        {
            
            this.ChosenRoomTypes = JsonConvert.DeserializeObject<List<ChosenRoomType>>(ChosenRoomTypes);
        }
    }
}
