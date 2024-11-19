using Designs.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Adapter
{
    public class SuperGreenEngineAdapter: AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine engine) : base(engine.EngineSize, false)
        {
        }
    }
}
