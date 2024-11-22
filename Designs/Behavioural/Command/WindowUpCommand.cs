using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class WindowUpCommand : IVoiceCommand
    {
        private ElectricWindow _window;
        public WindowUpCommand(ElectricWindow window)
        {
            _window = window;
        }
        public virtual void Execute()
        {
            _window.CloseWindow();
        }

       
    }
}
