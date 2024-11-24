using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Mediator
{
    public class EngineManagementSystem
    {
        private Ignition ignition;
        private Gearbox gearbox;
        private Accelerator accelerator;
        private Brake brake;
        private bool engineEnabled;
        private bool gearBoxEnabled;
        private bool ignitionEnabled;
        private bool acceleratorEnabled;
        private bool brakeEnabled;
        private Gear currentGear;
        private int currentSpeed;
        public EngineManagementSystem()
        {
            engineEnabled = false;
            gearBoxEnabled = false;
            ignitionEnabled = false;
            acceleratorEnabled = false;
            brakeEnabled = false;
            currentGear = Gear.NEUTRAL;
            currentSpeed = 0;
        }
        public void RegisterIgnition(Ignition ignition)
        {
            this.ignition = ignition;
        }
        public virtual void RegisterGearbox(Gearbox gearbox)
        {
            this.gearbox = gearbox;
        }
        public virtual void RegisterAccelerator(Accelerator accelerator)
        {
            this.accelerator = accelerator;
        }
        public virtual void RegisterBrake(Brake brake)
        {
            this.brake = brake;
        }
        public void IgnitionTurnedOn()
        {
            gearbox.Enable();
            accelerator.Enable();
            brake.Enable();
        }
        public virtual void IgnitionTurnedOff()
        {
            gearbox.Disable();
            accelerator.Disable();
            brake.Disable();
        }
        public virtual void GearboxEnabled()
        {
            Console.WriteLine("EMS enabling gearbox");
        }
        public void GearboxDisabled()
        {
            gearBoxEnabled = false;
            CheckAllSystems();
        }
        public void AcceleratorEnabled()
        {
           Console.WriteLine("EMS enabling Accelerator");
        }
        public void AcceleratorDisabled()
        {
            Console.WriteLine("EMS disabling Accelerator ");
        }
      
        public void CheckAllSystems()
        {
            if (ignitionEnabled && gearBoxEnabled && acceleratorEnabled && brakeEnabled)
            {
                engineEnabled = true;
            }
            else
            {
                engineEnabled = false;
            }
        }
        public void GearChanged()
        {
            if (engineEnabled)
            {
                Console.WriteLine("Gear changed to " + gearbox.InGear);
            }
        }
        public virtual void AcceleratorPressed()
        {
            brake.Disable();
            while (currentSpeed < accelerator.Speed)
            {
                currentSpeed++;
                Console.WriteLine("Speed increased to " + currentSpeed);
            }
            if (currentSpeed < 10)
            {
                currentGear = Gear.FIRST;
                Console.WriteLine("Gear changed to " + currentGear);
            }
            else if (currentSpeed < 20)
            {
                currentGear = Gear.SECOND;
                Console.WriteLine("Gear changed to " + currentGear);
            }
            else if (currentSpeed < 30)
            {
                currentGear = Gear.THIRD;
                Console.WriteLine("Gear changed to " + currentGear);
            }
            else if (currentSpeed < 40)
            {
                currentGear = Gear.FOURTH;
                Console.WriteLine("Gear changed to " + currentGear);
            }
            else 
            {
                currentGear = Gear.FIFTH;
                Console.WriteLine("Gear changed to " + currentGear);
            }
        }

        public virtual void BrakeEnabled()
        {
            Console.WriteLine("EMS enabling Brake");
        }

        public virtual void BrakePressed()
        {
            accelerator.Disable();
            currentSpeed = 0;
        }

        public virtual void BrakeDisabled()
        {
            Console.WriteLine("EMS disabling Brake ");
        }
    }
}