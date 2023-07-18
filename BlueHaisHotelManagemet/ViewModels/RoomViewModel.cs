using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace BlueHaisHotelManagemet.ViewModels
{
    public class RoomVIewModel
    {
        [Key]
        public int RoomId { get; set; }

        [Display(Name = "Room No")]
        public string RoomNumber { get; set; }

        [Display(Name = "Room Price")]
        public Decimal RoomPrice { get; set; }

        [Display(Name = "Booking Status")]
        public int BookingStatusId { get; set; }

        [Display(Name = "Room Type")]
        public int RoomTypeId { get; set; }

        [Display(Name = "Room Capacity")]
        public int RoomCapacity { get; set; }

        [Display(Name = "Room Description")]
        public string RoomDescription { get; set; }

        [Display(Name = "Upload Room Image")]
        public string RoomImage { get; set; }
        
        public HttpPostedFileBaseModelBinder Image { get; set; }

        
        public List<SelectListItem> ListOfBookingStatus { get; set; }
        public List<SelectListItem> ListofRoomType { get; set; }

    }
}
