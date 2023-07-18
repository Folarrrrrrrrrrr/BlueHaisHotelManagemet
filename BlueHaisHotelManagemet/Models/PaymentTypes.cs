using System.ComponentModel.DataAnnotations;

namespace BlueHaisHotelManagemet.Models
{
    public class PaymentTypes
    {
        [Key]
        public int PaymentTypeId { get; set; }

        public string PaymentType { get; set; }

    }
}
