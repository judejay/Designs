using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Facade
{
    public class Facade
    {
        IVehicle myCar = new Saloon(new StandardEngine(1300));

        // Facade Pattern
        // Provide a unified interface to a set of interfaces in a subsystem
        // Facade defines a higher-level interface that makes the subsystem easier to use

        public void Run()
        {
            
            Console.WriteLine("Facade Pattern");
            Console.WriteLine("--------------");
            // Facade
            VehicleFacade carFacade = new VehicleFacade();
            carFacade.PrepareForSale(myCar);
            Console.WriteLine();
        }
    }
}
