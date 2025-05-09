﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventEase_WebApplication.Models
{
    public class Booking
    {
        [Key] public int BookingID { get; set; }

        public int EventID { get; set; }

        public Event? Event { get; set; }

        public int VenueID { get; set; }

        public Venue? Venue { get; set; }

        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime EventBooking { get; set; }
    }
}
