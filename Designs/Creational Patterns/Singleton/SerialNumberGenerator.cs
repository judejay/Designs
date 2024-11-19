using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Singleton
{
    public class SerialNumberGenerator
    {
        //static members
        private static volatile SerialNumberGenerator instance;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SerialNumberGenerator();
                }
                return instance;
            }
        }

        //instance variables
        private int count;

        //private constructor
        private SerialNumberGenerator()
        {
            count = 0;
        }

        //instance method
        public virtual int NextSerial
        {
            get
            {
                return ++count;
            }
        }
    }

}
