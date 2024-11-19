using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Factory
{
    public class VanFactory: VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical || style == DrivingStyle.Midrange)
            {
                return new Pickup(new StandardEngine(2200));
            }
            else
            {
                return new BoxVan(new TurboEngine(2500));
            }
        }

    }
}
