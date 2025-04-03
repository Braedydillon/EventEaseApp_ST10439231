using System.ComponentModel.DataAnnotations;

namespace EventEase_WebApplication.Models
{
    public class Event
    {
        [Key] public int EventID { get; set; }

        public string? EventName { get; set; }

        public string? Description { get; set; }
        [Display(Name = "Event Specific Data ")]
        
        public String? EventSpecificInfo { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventBooking { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();



    }
}
