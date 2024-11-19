using Designs.Abstract_Classes;
using Designs.Abstractions;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Concrete_Classes
{
    internal class Pickup: AbstractVan
    {
        public Pickup(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }
        public Pickup(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
    
}
