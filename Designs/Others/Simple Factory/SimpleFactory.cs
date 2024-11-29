using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others.Simple_Factory
{
    public class SimpleFactory
    {

        // Factory method

        public void Run()
        {
            Gearbox gearbox = GearboxFactory.CreateGearbox(GearboxFactory.GearboxType.Manual);
            gearbox = GearboxFactory.CreateGearbox(GearboxFactory.GearboxType.Automatic);
        }
    }
}
