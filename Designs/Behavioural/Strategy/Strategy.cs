using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Strategy
{
    public class Strategy
    {
        //Strategy pattern
        // The Strategy pattern is a behavioural design pattern that enables selecting an algorithm at runtime — i.e., as and when it is required.
    
        public void Run()
        {
            AbstractCar myCar = new Saloon(new StandardEngine(1300));
            myCar.Speed = 20;
            myCar.Speed = 40;
            myCar.Speed = 70;
            myCar.Speed = 100;

            Console.WriteLine("Switching on sports mode...");
            myCar.GearboxStrategy = new SportGearboxStrategy();
            myCar.Speed = 20;
            myCar.Speed = 100;

            Console.ReadLine();
        }
    }
}
