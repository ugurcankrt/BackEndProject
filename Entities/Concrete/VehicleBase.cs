using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class VehicleBase
    {
        [Key]
        public int VehicleId { get; set; }

        public int ColorId { get; set; }
    }
}
