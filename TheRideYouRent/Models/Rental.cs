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
        public int RentalId { get; set; }

        [ForeignKey("driver_id")]
        [Display(Name = "Driver Id")]
        [Column("driver_id")]
        public int DriverId { get; set; }

        [ForeignKey("inspector_id")]
        [Display(Name = "Inspector Id")]
        [Column("inspector_id")]
        public int InspectorId { get; set; }

        [ForeignKey("car_id")]
        [Display(Name = "Car Id")]
        [Column("car_id")]
        public int CarId { get; set; }

        [Display(Name = "Rental Fee")]
        [Column("rental_fee")]
        public int RentalFee { get; set; }

        [Display(Name = "Start Date")]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Column("end_date")]
        public DateTime EndDate { get; set; }
    }
}
