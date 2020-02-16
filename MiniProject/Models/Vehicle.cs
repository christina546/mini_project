using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Vehicle
    {
        [Key]
        [Display(Name = "Vehicle ID")]
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "{0} is required." )]
        public string id { get; set; }


        [Display(Name = "Vehicle Type")]
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "{0} is required.")]
        public string vehicleType { get; set; }


        [DisplayName("Make")]
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "{0} is required.")]
        public string make { get; set; }


        [DisplayName("Model")]
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "{0} is required.")]
        public string model { get; set; }
 

    }
}
