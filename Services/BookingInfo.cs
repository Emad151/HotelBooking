namespace HotelBookingSystem.Services
{
	public record BookingInfo
	{
		public BookingDuration BookingDuration { get; set; }
		public List<ChosenRoomType> ChosenRoomTypes { get; set; }
		public int NumberOfAdults { get; set; }
		public int NumberOfChildren {  get; set; }
		public int MealPlanId {  get; set; }

	}
}
