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
        public int carId { get; set; }

        public string make { get; set; }

        public string model { get; set; }
        
        [Display(Name = "Body Type")]
        [Column("body_type")]
        public string bodyType { get; set; }

        [Display(Name = "Kilometers Travelled")]
        [Column("kilometers_travelled")]
        public int kilometersTravelled { get; set; }

        [Display(Name = "Service Kilometers")]
        [Column("service_kilometers")]
        public int serviceKilometers { get; set; }

        public string available { get; set; }
    }
}
