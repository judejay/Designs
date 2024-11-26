using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Template
{
    public class Template
    {

        // template pattern
        // 1. Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
        // 2. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    public void Run()
        {
            AbstractBookletPrinter serviceHistoryBooklet = new ServiceHistoryBooklet();
            serviceHistoryBooklet.Print();
            AbstractBookletPrinter saloonBooklet = new SaloonBookletPrinter();
            saloonBooklet.Print();
        }
    }
}
