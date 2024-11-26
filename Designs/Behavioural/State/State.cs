using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public class State
    {
        // State paatern
        // Allow an object to alter it's behaviour when it's internal state changes.
        // The object will appear to change its class

        public void Run() 
        {
            ClockSetup clockSetup = new ClockSetup();
            //Setup starts in year setup state  

            clockSetup.RotateKnobRight();
            clockSetup.PushKnob();
            // Year should be 1 more than current year
            //Setup should move to month setup state
            clockSetup.RotateKnobRight();
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob();
            // Month should be 2 more than current month
            //Setup should move to day setup state
            clockSetup.RotateKnobRight();
            clockSetup.RotateKnobRight();
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob();
            // Day should be 3 more than current day
            //Setup should move to hour setup state
            clockSetup.RotateKnobLeft();
            clockSetup.RotateKnobLeft();
            clockSetup.PushKnob();
            // Hour should be 2 less than current hour
            //Setup should move to minute setup state
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob();
            // Minute should be 1 more than current minute
            //Setup should move to finished setup state
            clockSetup.PushKnob();
            //Setup should be finished
            Console.ReadLine();


        }
    }
}
