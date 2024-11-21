using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Facade
{
    public class Registration
    {
        private IVehicle vehicle;
        public Registration(IVehicle vehicle)
        {
            this.vehicle = vehicle;   
        }

        public virtual void AllocateLicensePlate()
        {
            Console.WriteLine("Allocating license plate...");
        }

        public virtual void AllocateVehicleNumber()
        {
            Console.WriteLine("Allocating vehicle number...");
        }
    }
}
