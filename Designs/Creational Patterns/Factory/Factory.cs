using Designs.Abstractions;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Designs.Creational_Patterns.Factory.VehicleFactory;

namespace Designs.Creational_Patterns.Factory
{
    //Define an interface for creating an object,
    //but let subclasses decide which class to instantiate.
    //Factory Method lets a class defer instantiation to subclasses.
    public class Factory
    {

        //Create a red sports car

        public void CreateFactory()
        {
            IVehicle sporty = VehicleFactory.Make(VehicleFactory.Category.Car, DrivingStyle.Powerful, VehicleColour.Red);
            Console.WriteLine(sporty);
            Console.ReadLine();
        }
    }
}
