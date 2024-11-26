using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class MonthSetupState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int month;
        public MonthSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            month = DateTime.Now.Month;
        }
        public virtual void PreviousValue()
        {
            month--;
            if (month < 1)
            {
                month = 12;
            }
        }
        public virtual void NextValue()
        {
            month++;
            if (month > 12)
            {
                month = 1;
            }
        }
        public virtual void SelectValue()
        {
            Console.WriteLine("Month set to " + month);
            clockSetup.State = clockSetup.DaySetupState;
        }
        public virtual string Instructions
        {
            get
            {
                return "Please set the month...";
            }
        }
        public virtual int SelectedValue
        {
            get
            {
                return month;
            }
        }
    }
}
