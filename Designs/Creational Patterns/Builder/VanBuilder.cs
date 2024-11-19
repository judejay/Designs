using Designs.Abstract_Classes;
using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Builder
{
    public class VanBuilder: VehicleBuilder
    {
        private AbstractVan _vanInProgress ;

        public VanBuilder(AbstractVan van)
        {
            _vanInProgress = van;
        }
        public override void BuildBody()
        {
            Console.WriteLine("Building van body");
        }
       
        public override void BuildChassis()
        {
            Console.WriteLine("Building van chassis");
        }
        
        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("Building van reinforced storage area");
        }
        public override void BuildWindows()
        {
            Console.WriteLine("Building van windows");
        }

       

        public override IVehicle Vehicle
        {
            get { return _vanInProgress; }
        }
    }
}
