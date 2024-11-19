using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Builder
{
    public class CarDirector: VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildBoot();
            builder.BuildChassis();
            builder.BuildPassengerArea();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
