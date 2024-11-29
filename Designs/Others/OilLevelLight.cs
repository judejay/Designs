using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others
{
    public class OilLevelLight : IWarningLight
    {
        private bool _on;

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }

        public bool IsOn()
        {
            return _on;
        }
    }
    
}
