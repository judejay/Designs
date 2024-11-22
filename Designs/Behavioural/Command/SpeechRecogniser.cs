using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class SpeechRecogniser
    {

        private IVoiceCommand upCommand, downCommand, lastCommand;
        public virtual void SetCommands(IVoiceCommand upCommand, IVoiceCommand downCommand)
        {
            this.upCommand = upCommand;
            this.downCommand = downCommand;
           
        }


        public virtual void HearUpSpoken()
        {
            upCommand.Execute();
            lastCommand = upCommand;
        }

        public virtual void HearDownSpoken()
        {
            downCommand.Execute();
            lastCommand = downCommand;
        }

        public virtual void HearUndoSpoken()
        {
            lastCommand?.Undo();
        }

    }
}
