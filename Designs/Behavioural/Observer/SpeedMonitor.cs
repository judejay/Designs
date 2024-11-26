using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Observer
{
    public class SpeedMonitor
    {
        public const int SpeedToAlert = 70;
        public SpeedMonitor(Speedometer speedometer)
        {
            speedometer.ValueChanged += ValueChanged;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            Speedometer speedo = (Speedometer)sender;
            if (speedo.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine("** ALERT ** Driving too fast! (" + speedo.CurrentSpeed + ")");
            }
            else
            {
                Console.WriteLine("... nice and steady... (" + speedo.CurrentSpeed + ")");
            }
        }
    }
}
