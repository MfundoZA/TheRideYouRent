using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheRideYouRent.Models
{
    public class Return
    {
        [Key]
        [Column("return_id")]
        public int returnId { get; set; }

        [ForeignKey("rental_id")]
        [Column("rental_id")]
        public int rentalId { get; set; }

        [Column("return_date")]
        public DateTime returnDate { get; set; }

        public int fine { get; set; }
    }
}
