using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Mediator
{
    public class Accelerator
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private int speed;
        public Accelerator(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            speed = 0;
            mediator.RegisterAccelerator(this);
        }
        public void Enable()
        {
            enabled = true;
            mediator.AcceleratorEnabled();
            Console.WriteLine("Accelerator enabled");
        }
        public void Disable()
        {
            enabled = false;
            mediator.AcceleratorDisabled();
            Console.WriteLine("Accelerator disabled");
        }
        public bool Enabled()
        {
            return enabled;
        }
        public virtual int Speed
        {
            
            get
            {
                return speed;
            }
        }

        public virtual void AccelerateToSpeed(int speed)
        {
            if (Enabled())
            {
                this.speed = speed;
                Console.WriteLine("Speed changed to " + speed);
            }
        }
    }
}
