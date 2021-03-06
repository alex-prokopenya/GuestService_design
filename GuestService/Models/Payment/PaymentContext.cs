﻿namespace GuestService.Models.Payment
{
    using GuestService.Data;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class PaymentContext
    {
        public bool Success
        {
            get;
            set;
        }

        public string Order
        {
            get;
            set;
        }

        public List<PaymentMode> PaymentModes { get; set; }

        public ReservationState Reservation { get; set; }
    }
}

