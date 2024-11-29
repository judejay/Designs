using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others.Simple_Factory
{
    public class ManualGearbox : Gearbox
    {
        public ManualGearbox()
        {
            Console.WriteLine("Manual gearbox created");
        }
    }
   
}
