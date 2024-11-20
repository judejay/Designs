using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Bridge
{
    public class SportControls: AbstractDriverControls
    {
        public SportControls(IEngine engine) : base(engine)
        {

        }

        public void AccelerateHard()
        {
            Accelerate();
            Accelerate();
        }
    }
   
}
