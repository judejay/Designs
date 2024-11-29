using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Others.Simple_Factory
{
    public class GearboxFactory
    {

        public enum GearboxType
        {
            Manual,
            Automatic
        }

        public static Gearbox CreateGearbox(GearboxType type)
        {
            if (type == GearboxType.Manual)
            {
                return new ManualGearbox();
            }
            else if (type == GearboxType.Automatic)
            {
                return new AutomaticGearbox();
            }
            else
            {
                throw new ArgumentException("Invalid gearbox type");
            }
        }
    }
}