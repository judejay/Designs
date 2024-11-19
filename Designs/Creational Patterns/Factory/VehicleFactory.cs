using Designs.Abstractions;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Factory
{
    public abstract class VehicleFactory
    {
        public enum Category
        {
            Car,
            Van
        }
        public enum DrivingStyle
        {
            Economical,
            Midrange,
            Powerful
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle vehicle = SelectVehicle(style);
            vehicle.Paint(colour);
            return vehicle;
        }
        //This is the factory method
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
   
        public static IVehicle Make(Category cat,  DrivingStyle style, VehicleColour colour)
        {
            VehicleFactory factory ;
            if (cat == Category.Car)
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }
            return factory.Build(style, colour);
        }
    }


}
