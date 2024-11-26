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
    public abstract class AbstractCar : AbstractVehicle
    {
        private IGearboxStrategy gearboxStrategy;

        public AbstractCar(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour)
        { //Starts in standard gearbox mode
            gearboxStrategy = new StandardGearboxStrategy();
        }

        //Allow the gearbox strategy to be changed
        public virtual IGearboxStrategy GearboxStrategy
        {
            set { gearboxStrategy = value; }
            get { return gearboxStrategy; }
        }

        public virtual int Speed
        {
            set
            {
                //Delegate to strategy in order to calculate gear   

                if (gearboxStrategy != null)
                {
                    gearboxStrategy.EnsureCorrectGear(Engine, value);
                }
            }

        }
    }
}
