using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Abstract_Factory
{
    public class VanFactory: AbstractVehicleFactory
    {
        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }
        public override IBody CreateBody()
        {
            return new VanBody();
        }
        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
    
}
