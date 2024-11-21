using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Facade
{
    public class Documentation
    {
        public static void PrintBrochure(IVehicle vehicle)
        {
            Console.WriteLine("Printing Brochure");
        }
        
    }
}
