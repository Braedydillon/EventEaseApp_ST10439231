using System.ComponentModel.DataAnnotations;

namespace EventEase_WebApplication.Models
{
    public class Venue
    {
        [Key] public int VenueID { get; set; }

        public string? VenueName { get; set; }

        public string? Location { get; set; }
        public string? ImageURL { get; set; }
        public int  VenueCapcity { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();


    }
}
