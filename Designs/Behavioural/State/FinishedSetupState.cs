using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class FinishedSetupState: IClockSetupState

    {
        private ClockSetup clockSetup;
        public FinishedSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }

        public virtual void PreviousValue()
        {
            Console.WriteLine("Cannot change value");
        }
        public virtual void NextValue()
        {
            Console.WriteLine("Cannot change value");
        }

        public virtual void SelectValue()
        {
            DateTime selectedDate= clockSetup.SelectedDate;
            Console.WriteLine("Date set to " + selectedDate);
        }

        public virtual string Instructions
        {
            get
            {
                return "Please press the start button...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return 0;
            }
        }
    }
}
