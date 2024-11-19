using Designs.Creational_Patterns.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Abstract_Factory
{
    public class AbstractFactory
    {
        //Define an interface for creating families of related or dependent objects
        //without specifying their concrete classes.
        public void CreateVehicle()
        {
            string whatToMake = "car"; // or 'van'

            AbstractVehicleFactory factory = null;

            // Create the correct factory
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            // Create the vehicle's component parts
            // These will be either all car parts or all van parts
            IChassis chassis = factory.CreateChassis();
            IBody body = factory.CreateBody();
            IGlassware glass = factory.CreateGlassware();

            // Display the vehicle's components
            Console.WriteLine(chassis.ChassisParts);
            Console.WriteLine(body.BodyParts);
            Console.WriteLine(glass.GlasswareParts);
            Console.ReadLine();
        }
    }

}
