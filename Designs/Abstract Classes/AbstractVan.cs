using Designs.Abstractions;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Abstract_Classes
{
    public abstract class AbstractVan: AbstractVehicle
    {
        public AbstractVan(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }
        public AbstractVan(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
