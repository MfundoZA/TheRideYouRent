using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheRideYouRent.Models
{
    public class Rental
    {
        [Key]
        [Display(Name = "Rental Id")]
        [Column("rental_id")]
        public int rentalId { get; set; }

        [ForeignKey("driver_id")]
        [Display(Name = "Driver Id")]
        [Column("driver_id")]
        public int driverId { get; set; }

        [ForeignKey("inspector_id")]
        [Display(Name = "Inspector Id")]
        [Column("inspector_id")]
        public int inspectorId { get; set; }

        [ForeignKey("car_id")]
        [Display(Name = "Car Id")]
        [Column("car_id")]
        public int carId { get; set; }

        [Display(Name = "Rental Fee")]
        [Column("rental_fee")]
        public int rentalFee { get; set; }

        [Display(Name = "Start Date")]
        [Column("start_date")]
        public DateTime startDate { get; set; }

        [Display(Name = "End Date")]
        [Column("end_date")]
        public DateTime endDate { get; set; }
    }
}
