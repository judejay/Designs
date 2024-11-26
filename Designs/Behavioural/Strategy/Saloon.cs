using Designs.Abstract_Classes;
using Designs.Abstractions;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Designs.Behavioural.Strategy
{
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }
        public Saloon(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 6000;
            }
        }

    }
}