using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class SpeechRecogniser
    {

        private IVoiceCommand upCommand, downCommand;
        public virtual void SetCommands(IVoiceCommand upCommand, IVoiceCommand downCommand)
        {
            this.upCommand = upCommand;
            this.downCommand = downCommand;
           
        }


        public virtual void HearUpSpoken()
        {
            upCommand.Execute();
        }

        public virtual void HearDownSpoken()
        {
            downCommand.Execute();
        }

       
    }
}
