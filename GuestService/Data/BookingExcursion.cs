namespace GuestService.Data
{
    using System;
    using System.Runtime.CompilerServices;

    public class BookingExcursion
    {
        public ExcursionContact contact { get; set; }

        public DateTime date { get; set; }

        public int? extime { get; set; }

        public int? grouptype { get; set; }

        public int id { get; set; }

        public int? price_id
        {
            get;
            set;
        }

        public int? language { get; set; }

        public int? departure { get; set; }

        public string note { get; set; }

        public string curr { get; set; }

        public BookingPax pax { get; set; }

        public int? pickuphotel { get; set; }

        public int? pickuppoint { get; set; }

        public string pickuptime { get; set; }
    }
}

