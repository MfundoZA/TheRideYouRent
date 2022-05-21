using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheRideYouRent.Models
{
    public class Driver
    {
        [Key]
        [Column("driver_id")]
        public int driverId { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        [Column("cell_number")]
        public string cellNumber { get; set; }
    }
}
