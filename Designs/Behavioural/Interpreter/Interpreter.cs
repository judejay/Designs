using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Interpreter
{
    public class Interpreter
    {
        // Given a language, define a representation for its grammar along with an interpreter
        // that uses the representation to interpret sentences in the language.
        public void Run() 
        {
            //create the evaluator
            DirectionalEvaluator evaluator = new DirectionalEvaluator();

            //evaluate the route
            //This should return London
            Console.WriteLine(evaluator.Evaluate("london edinburgh manchester southerly"));

            //This should return Aberdeen
            Console.WriteLine(evaluator.Evaluate("london edinburgh manchester southerly aberdeen westerly"));

            //This should return Dublin
            Console.WriteLine(evaluator.Evaluate("london edinburgh manchester southerly aberdeen westerly dublin southerly"));

            // This should return Belfast
            Console.WriteLine(evaluator.Evaluate("london edinburgh manchester southerly aberdeen westerly dublin southerly belfast easterly"));
            Console.ReadLine();

           
        }

    }
}
