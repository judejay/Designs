using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Iterator
{
    public class VanRange
    {
        private IVehicle[] vans;

        public VanRange()
        {
            vans = new IVehicle[3];
            //Define the range of vans
            vans[0] = new BoxVan(new StandardEngine(1600));
            vans[1] = new BoxVan(new StandardEngine(2000));
            vans[2] = new Pickup(new TurboEngine(2200));
        }

        public virtual IVehicle[] Range
        {
            get
            {
                return vans;
            }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return ((IEnumerable<IVehicle>) vans).GetEnumerator();
        }
    }
}
