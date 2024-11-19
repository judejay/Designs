using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Abstract_Factory
{
    public class CarFactory: AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }
        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }
        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
    
}
