using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Iterator
{
    public class Iterator
    {

        // The Iterator interface declares the operations required for traversing a collection.
        public void Run()
        {
            Console.WriteLine("Our Vans");
            Console.WriteLine("========");
            // The client code may or may not know about the Concrete Iterator or Collection classes, depending on the level of indirection you want to keep in your program.
            VanRange vanRange = new VanRange();
            foreach (IVehicle curentVehicle in vanRange.Range)
            {
                Console.WriteLine(curentVehicle);
            }


            Console.WriteLine("Our Cars");
            Console.WriteLine("========");
            CarRange carRange = new CarRange();
            foreach (IVehicle curentVehicle in carRange.Range)
            {
                Console.WriteLine(curentVehicle);
            }
        }
    }
}
