using Designs.Abstract_Classes;
using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Builder
{
    public class Builder
    {

        //Seperating the construction of a complex object from its representation
        // so that the same construction process can create different representations.
        public void CreateBuilder() 
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            Console.WriteLine(v);
            Console.ReadLine();


        }
    }
}
