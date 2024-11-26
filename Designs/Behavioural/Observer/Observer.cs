using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Observer
{
    internal class Observer
    {

        // Observer pattern is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.
    public void Run()

        {
            Speedometer speedo = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(speedo);
            speedo.CurrentSpeed = 50;
            speedo.CurrentSpeed = 70;
            speedo.CurrentSpeed = 40;
            speedo.CurrentSpeed = 100;

            Console.ReadLine();
        }    
    }
}
