using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Prototype
{
    public class Prototype
    {
        // Specify the kinds of objects to create using a prototypical instance,
        // and create new objects by copying this prototype.

        public void Run()
        {
            Console.WriteLine("Prototype Pattern");
            Console.WriteLine("********************");
            // Create a prototype

            VehicleManager manager = new VehicleManager();
            IVehicle saloon1 = manager.CreateSaloon();
            IVehicle saloon2 = manager.CreateSaloon();
            IVehicle coupe1 = manager.CreateCoupe();
            IVehicle pickup1 = manager.CreatePickup();

            Console.WriteLine(saloon1);
            Console.WriteLine(saloon2);
            Console.WriteLine(coupe1);
            Console.WriteLine(pickup1);

            Console.ReadLine();
            
            Console.WriteLine("********************");
        }
    }
}
