using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class VolumnDownCommand: IVoiceCommand
    {
        private Radio _radio;
        public VolumnDownCommand(Radio radio)
        {
            _radio = radio;
        }
        public virtual void Execute()
        {
            _radio.VolumeDown();
        }

        public void Undo()
        {
            _radio.VolumeUp();
        }
    }
   
}
