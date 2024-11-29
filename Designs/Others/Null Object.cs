using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others
{
    public class Null_Object
    {
        // Null Object pattern is a way of handling null references in a program.
        public void Run()
        {
            IWarningLight[] warningLights = new IWarningLight[3];
            warningLights[0] = new BrakeFluidLight();
            warningLights[1] = new OilLevelLight();
            warningLights[2] = new NullObject();

            // No need to check for null    

            foreach (var warningLight in warningLights)
            {
                warningLight.TurnOn();
                Console.WriteLine(warningLight.IsOn());
                warningLight.TurnOff();
                Console.WriteLine(warningLight.IsOn());
            }
            Console.ReadLine();

        }
    }
}
