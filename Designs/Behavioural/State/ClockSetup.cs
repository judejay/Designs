using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class ClockSetup
    {
        // The various states the clock can be in
        private IClockSetupState yearSetupState;
        private IClockSetupState monthSetupState;
        private IClockSetupState daySetupState;
        private IClockSetupState hourSetupState;
        private IClockSetupState minuteSetupState;
        private IClockSetupState finishedState;

        // The current state of the clock
        private IClockSetupState currentState;

        public ClockSetup()
        {
            yearSetupState = new YearSetupState(this);
            monthSetupState = new MonthSetupState(this);
            daySetupState = new DaySetupState(this);
            hourSetupState = new HourSetupState(this);
            minuteSetupState = new MinuteSetupState(this);
            finishedState = new FinishedSetupState(this);

            //Initial state

            State = yearSetupState;

        }

        public virtual IClockSetupState State
        {
            set
            {
                currentState = value;
                Console.WriteLine(currentState.Instructions);
            }
        }

        public virtual void RotateKnobLeft()
        {
            currentState.PreviousValue();
        }

        public virtual void RotateKnobRight()
        {
            currentState.NextValue();
        }

        public virtual void PushKnob()
        {
            currentState.SelectValue();
        }

        public virtual IClockSetupState YearSetupState
        {
            get
            {
                return yearSetupState;
            }
        }

        public virtual IClockSetupState MonthSetupState
        {
            get
            {
                return monthSetupState;
            }
        }

        public virtual IClockSetupState DaySetupState
        {
            get
            {
                return daySetupState;
            }
        }

        public virtual IClockSetupState HourSetupState
        {
            get
            {
                return hourSetupState;
            }
        }

        public virtual IClockSetupState MinuteSetupState
        {
            get
            {
                return minuteSetupState;
            }
        }

        public virtual IClockSetupState FinishedState
        {
            get
            {
                return finishedState;
            }
        }

        public virtual DateTime SelectedDate
        {
            get
            {
                return new DateTime(yearSetupState.SelectedValue, monthSetupState.SelectedValue, daySetupState.SelectedValue, hourSetupState.SelectedValue, minuteSetupState.SelectedValue, 0);
            }
        }
    }
    }
