using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Adapter
{
    public class Adapter
    {

        // This is the target interface: it represents what the client
        // expects to work with.
        // It is the adapter's job to make new classes compatible with this one.
    IList<IEngine> engines = new List<IEngine>();
     
        public void Run()
        {
            // The client code can work with any class or collection that
            // follows the target interface.
            engines.Add(new StandardEngine(1200));
            engines.Add(new StandardEngine(1300));
            engines.Add(new StandardEngine(1600));
            engines.Add(new TurboEngine(2000));

            //Adapt the new engine type
            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            engines.Add(new SuperGreenEngineAdapter(greenEngine));

            foreach (IEngine engine in engines)
            {
                Console.WriteLine(engine);
            }
            Console.ReadLine();


        }
}
}
