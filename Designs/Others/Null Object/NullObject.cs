using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others
{
    public class NullObject : IWarningLight
    {
        public virtual void TurnOff()
        {
        }

        public virtual void TurnOn()
        {
        }

        public virtual bool IsOn()
        {
            return false;
        }
    }
}
