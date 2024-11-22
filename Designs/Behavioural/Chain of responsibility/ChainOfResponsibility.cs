using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Chain_of_responsibility
{
    public class ChainOfResponsibility
    {
        //Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
        //Chain the receiving objects and pass the request along the chain until an object handles it.

        public void Run()
        {
            string email = "I need my car repaired";
            AbstractEmailHandler.Handle(email);
            Console.ReadLine();

        }
    }
}
