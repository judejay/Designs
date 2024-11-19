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
        protected AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
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
    }
}
