using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class DaySetupState : IClockSetupState
    {
        private ClockSetup clockSetup;
        private int day;

        public DaySetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            day = DateTime.Now.Day;
        }

        public virtual void PreviousValue()
        {
            if (day > 1)
            {
                day--;
            }
        }

        public virtual void NextValue()
        {
            if (day < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                day++;
            }
        }

        public virtual void SelectValue()
        {
            Console.WriteLine("Day set to " + day);
            clockSetup.State = clockSetup.HourSetupState;
        }

        public virtual string Instructions
        {
            get
            {
                return "Please set the day...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return day;
            }
        }
    }
    }
