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
        public int ReturnId { get; set; }

        [ForeignKey("rental_id")]
        [Display(Name = "Rental Id")]
        [Column("rental_id")]
        public int RentalId { get; set; }

        [Display(Name = "Return Date")]
        [Column("return_date")]
        public DateTime ReturnDate { get; set; }

        public int Fine { get; set; }
    }
}
