using System;

namespace BTCMS
{
    // Simple model used by Search_Bus. Expand as needed.
    public class Bus
    {
        public string RouteId { get; }
        public string BusNumber { get; }
        public string BusName { get; }
        public TimeSpan Departure { get; }
        public TimeSpan Arrival { get; }
        public decimal Fare { get; }

        public Bus(string routeId, string busNumber, string busName, TimeSpan departure, TimeSpan arrival, decimal fare)
        {
            RouteId = routeId;
            BusNumber = busNumber;
            BusName = busName;
            Departure = departure;
            Arrival = arrival;
            Fare = fare;
        }
    }
}
