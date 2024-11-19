using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Factory
{
    public class CarFactory: VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical)
            {
                return new Saloon(new StandardEngine(1300));
            }
            else if (style == DrivingStyle.Midrange)
            {
                return new Coupe(new StandardEngine(1600));
            }
            else
            {
                return new Sport(new TurboEngine(2000));
            }
        }
    }
}
