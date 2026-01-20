using System;

namespace BTCMS
{
    public class Booking
    {
        public string BookingId { get; set; }
        public string BusNumber { get; set; }
        public string Route { get; set; }
        public DateTime JourneyDate { get; set; }
        public string SeatNumber { get; set; }
        public decimal Fare { get; set; }
        public string PassengerName { get; set; }
        public DateTime BookingDate { get; set; }

        public Booking()
        {
            BookingId = Guid.NewGuid().ToString();
            BookingDate = DateTime.Now;
        }
    }
}
