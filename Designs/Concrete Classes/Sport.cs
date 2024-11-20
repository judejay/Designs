using Designs.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Concrete_Classes
{
    internal class Sport: AbstractCar
    {
        // Benefits of using constructor chaining in C#:

        // 1. Code Reusability: Constructor chaining allows you to reuse code within the same class, reducing duplication and making the code easier to maintain.

        // 2. Simplified Initialization: It simplifies the initialization process by allowing you to provide default values for certain parameters, making it easier to create instances of the class with different sets of parameters.

        // 3. Improved Readability: Constructor chaining improves the readability of the code by clearly showing the relationship between different constructors and how they delegate to each other.

        // 4. Consistency: It ensures that all constructors eventually call a single constructor that contains the core initialization logic, ensuring consistency in the way objects are initialized.

        // Example of constructor chaining in the Sport class:
        public Sport(Abstractions.IEngine engine) : this(engine, Enums.VehicleColour.Unpainted)
        {
        }

        public Sport(Abstractions.IEngine engine, Enums.VehicleColour colour) : base(engine, colour)
        {
        }

        public override int Price
        {
            get
            {
                return 18000;
            }
        }
    }
    
}
