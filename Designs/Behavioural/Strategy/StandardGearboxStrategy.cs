using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Strategy
{
    public class StandardGearboxStrategy : IGearboxStrategy
    {
        public virtual void EnsureCorrectGear(IEngine engine, int speed)
        {
            int engineSize = engine.Size;
           // bool turbo = engine.Turbo;
            // Do some working out here
            Console.WriteLine("Working out correct gear at " + speed + "for standard gearbox of size " + engineSize);

        }
    }
}
