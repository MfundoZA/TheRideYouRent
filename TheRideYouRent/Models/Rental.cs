using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheRideYouRent.Models
{
    public class Rental
    {
        [Key]
        [Column("rental_id")]
        public int rentalId { get; set; }

        [ForeignKey("driver_id")]
        [Column("driver_id")]
        public int driverId { get; set; }

        [ForeignKey("inspector_id")]
        [Column("inspector_id")]
        public int inspectorId { get; set; }

        [ForeignKey("car_id")]
        [Column("inspector_id")]
        public int carId { get; set; }

        [Column("rental_fee")]
        public int rentalFee { get; set; }

        [Column("start_date")]
        public DateTime startDate { get; set; }

        [Column("end_date")]
        public DateTime endDate { get; set; }
    }
}
