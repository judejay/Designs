using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Decorator
{
    public class AlloyWheeledVehicle: AbstractVehicleOption
    {
        public AlloyWheeledVehicle(IVehicle vehicle) : base(vehicle)
        {
        }
        public override int Price
        {
            get
            {
                return decoratedVehicle.Price + 250;
            }
        }
    }
    
    
}
