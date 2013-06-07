namespace UX.Models
{
    public class InitialBookingViewModel
    {
        public string Title { get; set; }
        public string Splash { get; set; }
        public string BookingIntroduction { get; set; }
    }

    public class SearchRequest
    {
        public string Title { get; set; }
        public string Splash { get; set; }
        public string BookingIntroduction { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public short NoOfRooms { get; set; }
        public string City { get; set; }
    }
}