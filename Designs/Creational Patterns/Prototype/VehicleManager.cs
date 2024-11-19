using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Prototype
{
    public class VehicleManager
    {
        private IVehicle saloon, coupe, sport, boxVan, pickup;

        public VehicleManager()
        {
            saloon = new Saloon(new StandardEngine(1300));
            coupe = new Coupe(new StandardEngine(1300));
            sport = new Sport(new TurboEngine(2000));
            boxVan = new BoxVan(new StandardEngine(2200));
            pickup = new Pickup(new TurboEngine(2500));
        }

        public virtual IVehicle CreateSaloon()
        {
            return (IVehicle)saloon.Clone();
        }
        public virtual IVehicle CreateCoupe() {
            return (IVehicle)coupe.Clone();
        }
        public virtual  IVehicle CreateSport()
        {
            return (IVehicle)sport.Clone();
        }
        public virtual IVehicle CreateBoxVan()
        {
            return (IVehicle)boxVan.Clone();
        }
        public virtual IVehicle CreatePickup()
        {
            return (IVehicle)pickup.Clone();
        }
    }
}
