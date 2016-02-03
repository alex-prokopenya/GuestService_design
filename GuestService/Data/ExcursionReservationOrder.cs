namespace GuestService.Data
{
    using System;
    using System.Runtime.CompilerServices;

    public class ExcursionReservationOrder
    {
        public ExcursionReservationGroup grouptype { get; set; }

        public int id { get; set; }

        public ExcursionReservationLanguage language { get; set; }

        public string name { get; set; }

        public PickupPlace pickuphotel { get; set; }

        public PickupPlace pickuppoint { get; set; }

        public ExcursionReservationTime time { get; set; }

        public string included
        {
            get;
            set;
        }

        public string pickup //???
        {
            get;
            set;
        }
        public string code { get; set; }    //new
        public int guide { get; set; }      //new
        public int food { get; set; }       //new
        public int entryfees { get; set; }  //new
        public string cancelations { get; set; } //new
        public string stuff { get; set; }   //new
    }
}

