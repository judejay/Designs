using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Visitor
{
    public interface IVisitable
    {
        void AcceptEngineVisitor(IEngineVisitor visitor);

    }
}
