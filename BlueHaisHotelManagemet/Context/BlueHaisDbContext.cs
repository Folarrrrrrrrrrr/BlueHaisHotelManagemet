using BlueHaisHotelManagemet.Models;
using System.Collections.Generic;

namespace BlueHaisHotelManagemet.Context
{
    public class BlueHaisDbContext : DbContext
    {
        public BlueHaisDbContext(DbContextOptions<BlueHaisDbContext> options) : base(options)
        {
            
        }

        public static object BookingStatus { get; internal set; }


        public virtual DbSet<BookingStatus> BookingStatuses { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentTypes> paymentTypes { get; set; }
        public virtual DbSet<RoomBooking> roomBookings { get; set; }
        public virtual DbSet<Rooms> rooms { get; set; }
        public object Rooms { get; internal set; }
        public virtual DbSet<RoomType> roomTypes { get; set; }
    }
}
