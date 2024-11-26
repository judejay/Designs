using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class MinuteSetupState: IClockSetupState
    {
        private ClockSetup clockSetup;
        private int minute;
        public MinuteSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            minute = DateTime.Now.Minute;
        }
        public virtual void PreviousValue()
        {
            if (minute > 0)
            {
                minute--;
            }
        }
        public virtual void NextValue()
        {
            if (minute < 59)
            {
                minute++;
            }
        }
        public virtual void SelectValue()
        {
            Console.WriteLine("Minute set to " + minute);
            clockSetup.State = clockSetup.HourSetupState;
        }
        public virtual string Instructions
        {
            get
            {
                return "Please set the minute...";
            }
        }
        public virtual int SelectedValue
        {
            get
            {
                return minute;
            }
        }
    }
}
