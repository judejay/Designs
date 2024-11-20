using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Bridge
{
    public abstract class AbstractDriverControls
    {

        private IEngine engine;
        public AbstractDriverControls(IEngine engine)
        {
            this.engine = engine;
        }
        public void IgnitionOn()
        {
            engine.Start();
        }
        public void IgnitionOff()
        {
            engine.Stop();
        }
        public void Accelerate()
        {
            engine.IncreasePower();
        }
        public void Brake()
        {
            engine.DecreasePower();
        }
    }
}
