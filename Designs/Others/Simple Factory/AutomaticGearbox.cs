using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others.Simple_Factory
{
    public class AutomaticGearbox : Gearbox
    {
        public AutomaticGearbox()
        {
            Console.WriteLine("Automatic gearbox created");
        }
    }
}
