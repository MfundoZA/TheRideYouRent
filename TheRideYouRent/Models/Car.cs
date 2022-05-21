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
        [Column("car_id")]
        public int carId { get; set; }

        public string make { get; set; }

        public string model { get; set; }

        [Column("body_type")]
        public string bodyType { get; set; }

        [Column("kilometers_travelled")]
        public int kilometersTravelled { get; set; }

        [Column("service_kilometers")]
        public int serviceKilometers { get; set; }

        public string available { get; set; }
    }
}
