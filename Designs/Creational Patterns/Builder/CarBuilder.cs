using Designs.Abstract_Classes;
using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Builder
{
    public class CarBuilder: VehicleBuilder
    {
        private AbstractCar _carInProgress;
        public CarBuilder(AbstractCar car)
        {
            _carInProgress = car;
        }
        public override void BuildBody()
        {
            Console.WriteLine("Building car body");
        }
        public override void BuildBoot()
        {
            Console.WriteLine("Building car boot");
        }
        public override void BuildChassis()
        {
            Console.WriteLine("Building car chassis");
        }
        public override void BuildPassengerArea()
        {
            Console.WriteLine("Building car passenger area");
        }
       
        public override void BuildWindows()
        {
            Console.WriteLine("Building car windows");
        }
        public override IVehicle Vehicle
        {
            get { return _carInProgress; }
        }

    }
}
