using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class HourSetupState: IClockSetupState
    {
        private ClockSetup clockSetup;
        private int hour;
        public HourSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            hour = DateTime.Now.Hour;
        }
        public virtual void PreviousValue()
        {
            if (hour > 0)
            {
                hour--;
            }
        }
        public virtual void NextValue()
        {
            if (hour < 23)
            {
                hour++;
            }
        }
        public virtual void SelectValue()
        {
            Console.WriteLine("Hour set to " + hour);
            clockSetup.State = clockSetup.DaySetupState;
        }
        public virtual string Instructions
        {
            get
            {
                return "Please set the hour...";
            }
        }
        public virtual int SelectedValue
        {
            get
            {
                return hour;
            }
        }
    }
}
