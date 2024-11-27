using Designs.Abstractions;
using Designs.Behavioural.Visitor;
using Designs.Stuctural_Patterns.Flyweight;
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

        private Camshaft camshaft;
        private Piston piston;
        private SparkPlug[] sparkPlugs;
        protected AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            power = 0;
            running = false;

            camshaft = new Camshaft();
            piston = new Piston();
            sparkPlugs = new SparkPlug[]
            {
                new SparkPlug(),
                new SparkPlug(),
                new SparkPlug(),
                new SparkPlug()
            };
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

        public  virtual void Diagnose(IDiagnosticTool tool)
        {
            tool.RunDiagnosis(this);
        }

        public virtual void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            //Visit each component
            camshaft.AcceptEngineVisitor(visitor);
            piston.AcceptEngineVisitor(visitor);
            foreach (SparkPlug plug in sparkPlugs)
            {
                plug.AcceptEngineVisitor(visitor);
            }
            // Now visit the reciever
            visitor.Visit(this);

        }
    }
}
