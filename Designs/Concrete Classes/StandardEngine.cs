using Designs.Abstract_Classes;
using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Concrete_Classes
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbocharged

        }


    }

    public class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size) : base(size, true)
        {
            //turbocharged
        }


    }
}