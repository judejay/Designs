using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Mediator
{
    public class Gearbox
    {

        private EngineManagementSystem mediator;
        private bool enabled;
        private Gear currentGear;
        public Gearbox(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            currentGear = Gear.NEUTRAL;
            mediator.RegisterGearbox(this);
        }
        public void Enable()
        {
            enabled = true;
            mediator.GearboxEnabled();
            Console.WriteLine("Gearbox enabled");
        }
        public void Disable()
        {
            enabled = false;
            mediator.GearboxDisabled();
            Console.WriteLine("Gearbox disabled");
        }
        public bool Enabled()
        {
            return enabled;
        }
        public virtual Gear InGear
        {
            set
            {
                if ((Enabled()) && (currentGear != value))
                {
                    currentGear = value;
                    mediator.GearChanged();
                    Console.WriteLine("Gear changed to " + value);
                }
            }
            get
            {
                return currentGear;
            }
        }
       
    }
}
