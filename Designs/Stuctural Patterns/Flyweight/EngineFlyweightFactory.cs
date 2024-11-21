using Designs.Abstractions;
using Designs.Concrete_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Flyweight
{
    public class EngineFlyweightFactory
    {
        private IDictionary<int?, IEngine> standardEnginePool;
        private IDictionary<int?, IEngine> turboEnginePool;

        public EngineFlyweightFactory()
        {
            standardEnginePool = new Dictionary<int?, IEngine>();
            turboEnginePool = new Dictionary<int?, IEngine>();
        }

        public virtual IEngine GetStandardEngine(int size)
        {
            IEngine e = null;
            bool found = standardEnginePool.TryGetValue(size, out e);
            if (!found)
            {
                e = new StandardEngine(size);
                standardEnginePool[size] = e;
            }
            return e;

        }

        public virtual IEngine GetTurboEngine(int size)
        {
            IEngine e = null;
            bool found = turboEnginePool.TryGetValue(size, out e);
            if (!found)
            {
                e = new TurboEngine(size);
                turboEnginePool[size] = e;
            }
            return e;
        }
    }
}
