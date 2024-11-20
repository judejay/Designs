using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Bridge
{
    public class Bridge
    {

        public void Run(SportControls controls2)
        {
            IEngine engine = new StandardEngine(1300);
            AbstractDriverControls controls = new StandardControls(engine);
            controls.IgnitionOn();
            controls.Accelerate();
            controls.Brake();
            controls.IgnitionOff();
            Console.WriteLine();
            engine = new TurboEngine(2000);
            controls2 = new SportControls(engine);
            controls2.IgnitionOn();
            controls2.AccelerateHard();
            controls2.Accelerate();
            controls2.Brake();
            controls2.IgnitionOff();
        }
    }
}
