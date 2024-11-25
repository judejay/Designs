using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Memento
{
    [Serializable]
    public class Speedometer
    {
        private int currentSpeed;
        private int previousSpeed;
       
        public Speedometer()
        {
            currentSpeed = 0;
            previousSpeed = 0;
        }
        public virtual int currentSpeed()
        set {
            previousSpeed = currentSpeed;
            currentSpeed = value;
        }
    get {
            return currentSpeed;
        }

//Only defined to help testing
public virtual int previousSpeed()
{
    return previousSpeed;
}
}
}
