using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlueHaisHotelManagemet.Models
{
    public class RoomBooking
    {
        [Key]
        public int BookingId { get; set; }

        [StringLength(90)]
        public string CustonmerName { get; set; }
        public string CustomerAddress { get; set; }
        public System.DateTime BookingFrom { get; set; }
        public System.DateTime BookingTill { get; set; }
        public int AssignedRoomId { get; set; }
        public int NumberOfMembers { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal TotalAmount { get; set; }
    }
}
