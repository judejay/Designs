using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Singleton
{
    public class Singleton
    {

        // Singleton pattern
        // The Singleton pattern is a design pattern that restricts the instantiation of a class to one object.
        public void Run()
        {
            Console.WriteLine("Singleton Pattern");
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("Next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.ReadLine();
        }
    }
}
