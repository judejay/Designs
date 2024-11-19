using Designs.Abstractions;
using System;

namespace Designs.Stuctural_Patterns.Adapter
{
    public class SuperGreenEngine: object
    {

        public SuperGreenEngine(int v) { 
            this.EngineSize = v;
        }

        public int EngineSize { get; internal set; }
    }
}