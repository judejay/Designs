using Designs.Abstractions;
using Designs.Behavioural.Visitor;
using Designs.Concrete_Classes;
using Designs.Stuctural_Patterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Proxy
{
    public class EngineProxy : IEngine
    {
        private IEngine engine;

        public EngineProxy(int size, bool turbo)
        {
            if (turbo)
            {
                engine = new TurboEngine(size);
            }
            else
            {
                engine = new StandardEngine(size);
            }
        }

        public virtual int Size
        {
            get
            {
                return engine.Size;
            }
        }
        public virtual bool Turbo
        {
            get { return engine.Turbo; }
        }

        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void DecreasePower()
        {
            throw new NotImplementedException();
        }

        // This method is time-consuming...
        public virtual void Diagnose(IDiagnosticTool tool)
        {
            Console.WriteLine("Running tool as thread");
            Thread t = new Thread(() => RunDiagnosticTool(tool));
        }

        public void IncreasePower()
        {
            throw new NotImplementedException();
        }

        public virtual void RunDiagnosticTool(IDiagnosticTool tool)
        {
            tool.RunDiagnosis(this);
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
