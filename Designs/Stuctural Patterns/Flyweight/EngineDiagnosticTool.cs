using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Flyweight
{
    public class EngineDiagnosticTool: IDiagnosticTool
    {
        public virtual void RunDiagnosis(object obj)
        {
            Console.WriteLine("Starting engine diagnosis for " + obj);
            Thread.Sleep(3000);
            Console.WriteLine("Engine diagnosis complete");
        
        }

        
    }
}
