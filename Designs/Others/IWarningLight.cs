using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others
{
    public interface IWarningLight
    {

        void TurnOn();
        void TurnOff();
        bool IsOn();
    }
}
