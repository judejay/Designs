using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Visitor
{
    public class EngineInventory : IEngineVisitor
    {
        private int _camshaftCount;
        private int _pistonCount;
        private int _sparkPlugCount;

        public EngineInventory()
        {
            _camshaftCount = 0;
            _pistonCount = 0;
            _sparkPlugCount = 0;
        }
        public void Visit(Camshaft camshaft)
        {
            _camshaftCount++;
            Console.WriteLine("Camshaft has been visited");
        }
        public void Visit(Piston piston)
        {
            _pistonCount++;
            Console.WriteLine("Piston has been visited");
        }
        public void Visit(SparkPlug sparkPlug)
        {
            _sparkPlugCount++;
            Console.WriteLine("SparkPlug has been visited");
        }
        public void Visit(IEngine engine)
        {
            Console.WriteLine("Engine has : " + 
                _camshaftCount + " camshaft(s), " +
                _pistonCount + " pistons(s), " +
                _sparkPlugCount + " sparkplug(s)"); 
        }
    }
}
