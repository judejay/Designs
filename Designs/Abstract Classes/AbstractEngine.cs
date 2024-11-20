using Designs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Abstract_Classes
{
    public abstract class AbstractEngine : IEngine
    {
        private int size { get; }
        private bool turbo { get; }

        private bool running;
        private int power;
        protected AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            power = 0;
            running = false;
        }
        public virtual int Size { get { return size; } }


        public virtual bool Turbo
        {
            get { return Turbo; }
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + size + ")";
        }

        public virtual void Start()
        {
            running = true;
            Console.WriteLine("Engine started");
        }

        public virtual void Stop()
        {
            running = false;
            Console.WriteLine("Engine stopped");
        }

        public virtual void IncreasePower()
        {
            if (running && (power < 10))
            {
                power++;
                Console.WriteLine("Engine power increased to " + power);
            }
        }

        public virtual void DecreasePower()
        {
            if (running && (power > 0))
            {
                power--;
                Console.WriteLine("Engine power decreased to " + power);
            }

        }
    }
}
