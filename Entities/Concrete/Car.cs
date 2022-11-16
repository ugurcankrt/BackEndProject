using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : VehicleBase,IEntity
    {
        public bool HeadlightIsOpen { get; set; }

        public string Wheel { get; set; }
    }
}
