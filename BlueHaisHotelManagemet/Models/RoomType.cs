using System.ComponentModel.DataAnnotations;

namespace BlueHaisHotelManagemet.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        [StringLength(50)]
        public string RoomTypeName { get; set; }
    }
}
