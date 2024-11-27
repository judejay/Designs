using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Visitor
{
    public class Visitor
    {
        // Visitor pattern is a way of separating an algorithm from an object structure on which it operates.

        public void Run()
        {
            IEngine engine = new StandardEngine(1300);

            Console.WriteLine("Standard Engine Diagnostics");
            Console.WriteLine();
            engine.AcceptEngineVisitor(new EngineDiagnostics());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Standard Engine Inventory");
            Console.WriteLine();
            engine.AcceptEngineVisitor(new EngineInventory());
        }
    }
}
