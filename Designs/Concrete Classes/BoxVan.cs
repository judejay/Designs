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
    public class BoxVan: AbstractVan
    {
        public BoxVan(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }
        public BoxVan(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 10000;
            }
        }
    }
}
