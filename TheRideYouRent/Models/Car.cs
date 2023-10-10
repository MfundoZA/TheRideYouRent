using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheRideYouRent.Models
{
    public class Car
    {
        [Key]
        [Display(Name = "Car Id")]
        [Column("car_id")]
        public int CarId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
        
        [Display(Name = "Body Type")]
        [Column("body_type")]
        public string BodyType { get; set; }

        [Display(Name = "Kilometers Travelled")]
        [Column("kilometers_travelled")]
        public int KilometersTravelled { get; set; }

        [Display(Name = "Service Kilometers")]
        [Column("service_kilometers")]
        public int ServiceKilometers { get; set; }

        public string Available { get; set; }
    }
}
