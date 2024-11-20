using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Bridge
{
    public class StandardControls: AbstractDriverControls
    {
        public StandardControls(IEngine engine) : base(engine)
        {
        }
    }
    
}
