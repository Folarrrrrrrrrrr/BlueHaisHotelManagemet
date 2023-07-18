using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlueHaisHotelManagemet.Models
{
    public class Payments
    {
        [Key]
        [StringLength(15)]
        public int PaymentId { get; set; }
        public int BookingId { get; set; }

        [ForeignKey("PaymentTypes")]
        public int PaymentTypeId { get; set; }

        public virtual int PaymentTypes { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PaymentAmount { get; set; }


        public bool IsActive { get; set; }   
    }
}
