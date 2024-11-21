using Designs.Stuctural_Patterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Proxy
{
    public class Proxy
    {
        IDiagnosticTool tool = new EngineDiagnosticTool();

        public void Run()
        { 
            EngineProxy engineProxy = new EngineProxy(1300, false);
            engineProxy.Diagnose(tool);
        }
    }
}
