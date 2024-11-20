using Designs.Abstract_Classes;
using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Decorator
{
    public abstract class AbstractVehicleOption: AbstractVehicle
    {
        protected internal IVehicle decoratedVehicle;
        public AbstractVehicleOption(IVehicle vehicle)
            : base(vehicle.Engine)
        {
            decoratedVehicle = vehicle;
        }
    }
}
