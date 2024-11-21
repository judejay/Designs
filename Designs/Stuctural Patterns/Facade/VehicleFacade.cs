using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Facade
{
    public class VehicleFacade
    {

        public virtual void PrepareForSale(IVehicle vehicle)
        {
            Registration reg = new Registration(vehicle);
            reg.AllocateVehicleNumber();
            reg.AllocateLicensePlate();
            Documentation.PrintBrochure(vehicle);

            vehicle.CleanInterior();
            vehicle.CleanExteriorBody();
            vehicle.PolishWindows();
            vehicle.TakeForTestDrive();
        }
    }
}
