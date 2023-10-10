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
        [Display(Name = "Driver Id")]
        [Column("driver_id")]
        public int DriverId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        [Display(Name = "Cell Number")]
        [Column("cell_number")]
        public string CellNumber { get; set; }
    }
}
