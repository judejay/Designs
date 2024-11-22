using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class WindowDownCommand: IVoiceCommand
    {
        private ElectricWindow _window;

        public WindowDownCommand(ElectricWindow window)
        {
            _window = window;
        }

        public virtual void Execute()
        {
            _window.OpenWindow();
        }

         
    }
}
