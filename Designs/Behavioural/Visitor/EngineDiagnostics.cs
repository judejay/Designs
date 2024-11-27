using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Visitor
{
    public class EngineDiagnostics: IEngineVisitor
    {
        public void Visit(Camshaft camshaft)
        {
            Console.WriteLine("Diagnosing the camshaft");
        }
        public void Visit(Piston piston)
        {
            Console.WriteLine("Diagnosing the piston");
        }
        public void Visit(SparkPlug sparkPlug)
        {
            Console.WriteLine("Diagnosing the spark plug");
        }
        public void Visit(IEngine engine)
        {
            Console.WriteLine("Diagnosing the engine");
        }
    }
}
