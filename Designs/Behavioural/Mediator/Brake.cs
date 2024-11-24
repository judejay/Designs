using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Mediator
{
    public class Brake
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private bool applied;
        public Brake(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            applied = false;
            mediator.RegisterBrake(this);
        }
        public virtual void Enable()
        {
            enabled = true;
            mediator.BrakeEnabled();
            Console.WriteLine("Brake enabled");
        }
        public virtual void Disable()
        {
            enabled = false;
            mediator.BrakeDisabled();
            Console.WriteLine("Brake disabled");
        }
        public virtual bool Enabled()
        {
            return enabled;
        }

        public virtual void Apply()
        {
            if (Enabled())
            {
                applied = true;
                mediator.BrakePressed();
                Console.WriteLine("Brake applied");
            }
        }

        public virtual void Release()
        {
            if (Enabled())
            {
                applied = false;
                Console.WriteLine("Brake released");
            }
        }
    }
}
