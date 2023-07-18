using System.ComponentModel.DataAnnotations;

namespace BlueHaisHotelManagemet.Models
{
    public class BookingStatus
    {
        [Key]
        public long BookingStatusId { get; set; }

        [StringLength(50)]
        [Required]
        public string CurrentBookingStatus { get; set; }
    }
}
