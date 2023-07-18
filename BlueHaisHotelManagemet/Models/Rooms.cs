using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlueHaisHotelManagemet.Models
{
    public class Rooms
    {
        [Key]
        public int RoomsId { get; set; }

        public string RoomNumber { get; set; }

        public string RoomImage { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RoomPrice { get; set; }

        [ForeignKey("BookingStatus")]
        public int BookingStatusId { get; set; }
        public virtual BookingStatus BookingStatus { get; set; }

        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType{ get; set; }

        public int RoomCapacity { get; set; }
        [StringLength(550)]
        public string RoomDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
