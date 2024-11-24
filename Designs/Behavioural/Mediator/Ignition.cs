using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Mediator
{
    public class Ignition
    {

        private EngineManagementSystem mediator;
        private bool on;

        //Constructor accepts mediator as an argument

        public Ignition(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            on = false;
            mediator.RegisterIgnition(this);
        }

        public void Start()
        {
            on = true;
            mediator.IgnitionTurnedOn();
            Console.WriteLine("Ignition turned on");
        }

        public void Stop()
        {
            on = false;
            mediator.IgnitionTurnedOff();
            Console.WriteLine("Ignition turned off");
        }

        public bool IsOn()
        {
            return on;
        }
    }
}
