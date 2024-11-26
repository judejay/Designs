using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Strategy
{
    public interface IGearboxStrategy
    {
        void EnsureCorrectGear(IEngine engine, int speed);
    }
}
