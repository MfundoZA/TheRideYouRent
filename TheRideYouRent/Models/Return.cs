using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheRideYouRent.Models
{
    public class Return
    {
        [Key]
        [Display(Name = "Return Id")]
        [Column("return_id")]
        public int returnId { get; set; }

        [ForeignKey("rental_id")]
        [Display(Name = "Rental Id")]
        [Column("rental_id")]
        public int rentalId { get; set; }

        [Display(Name = "Return Date")]
        [Column("return_date")]
        public DateTime returnDate { get; set; }

        public int fine { get; set; }
    }
}
