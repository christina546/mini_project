using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Car : Vehicle
    {
        [Display(Name = "Engine")]
        [Column(TypeName = "nvarchar(250)")]
        public string engine { get; set; }

        [Display(Name = "Number of Doors")]
        [Column(TypeName = "bigint")]
        public int numDoors { get; set; }

        [Display(Name = "Number of Wheels")]
        [Column(TypeName = "bigint")]
        public int numWheels { get; set; }

        [Display(Name = "Bodytype")]
        [Column(TypeName = "nvarchar(250)")]
        public string bodyType { get; set; }

    }
}
