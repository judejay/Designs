using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Chain_of_responsibility
{
    public class ServiceEmailHandler: AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "service", "repair" };
        }
        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This is a service email");
        }
    }
  
}
