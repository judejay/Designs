using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Mediator
{
    public class Mediator
    {
        // Mediator pattern is used to reduce communication complexity between multiple objects or classes.
     public void Run()
        {
            EngineManagementSystem mediator = new EngineManagementSystem();
            Ignition ignition = new Ignition(mediator);
            Accelerator accelerator = new Accelerator(mediator);
            Brake brake = new Brake(mediator);
            Gearbox gearbox = new Gearbox(mediator);
            
            ignition.Start();
            
            accelerator.AccelerateToSpeed(100);
            
            accelerator.AccelerateToSpeed(0);
            
            ignition.Stop();
        }
    }
}
