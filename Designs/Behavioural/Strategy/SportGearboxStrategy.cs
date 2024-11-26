using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Strategy
{
    public class SportGearboxStrategy : IGearboxStrategy
    {

        public virtual void EnsureCorrectGear(IEngine Engine, int speed)
        {
            int engineSize = Engine.Size;
           // bool turbo = Engine.Turbo;
            Console.WriteLine("Working out correct gear at " + speed + "for Sport gearbox " + engineSize);
        }

        

    }
}
