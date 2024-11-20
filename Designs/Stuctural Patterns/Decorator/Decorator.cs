using Designs.Abstractions;
using Designs.Concrete_Classes;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Decorator
{
    public class Decorator
    {

        // Decorator Pattern
        // The Decorator pattern is used to add new functionality to an existing object without altering its structure.
        // The Decorator pattern is a structural pattern that allows adding new behaviors to objects dynamically
        // by placing them inside special wrapper objects called decorators.

        public void Run()
        {
            IVehicle myCar = new Saloon(new StandardEngine(1300));
            myCar.Paint(VehicleColour.Green);

            // Add air-conditioning to the car
            myCar = new AirCondiotionedVehicle(myCar);

            Console.WriteLine(myCar);
            //Add alloy wheels to the car
            myCar = new AlloyWheeledVehicle(myCar);
            Console.WriteLine(myCar);
            //Add leather seats to the car
            myCar = new LeatherSeatedVehicle(myCar);
            Console.WriteLine(myCar);
            //Add metallic paint to the car
            myCar = new MetallicPaintedVehicle(myCar);
            Console.WriteLine(myCar);
            //Add satellite navigation to the car
            myCar = new SatNavVehicle(myCar);

            Console.WriteLine(myCar);
        }

        }
    }
