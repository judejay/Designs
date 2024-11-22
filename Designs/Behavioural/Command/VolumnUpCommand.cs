using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class VolumnUpCommand: IVoiceCommand
    {

        private Radio _radio;

        public VolumnUpCommand(Radio radio)
        {
            _radio = radio;
        }

        public virtual void Execute()
        {
            _radio.VolumeUp();
        }

        public virtual void Undo()
        {
            _radio.VolumeDown();
        }
    }
}
