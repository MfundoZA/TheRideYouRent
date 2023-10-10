using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheRideYouRent.Models
{
    public class Inspector
    {
        [Key]
        [Display(Name = "Inspector Id")]
        [Column("inspector_id")]
        public int inspectorId { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        [Display(Name = "Cell Number")]
        [Column("cell_number")]
        public string cellNumber { get; set; }
    }
}
