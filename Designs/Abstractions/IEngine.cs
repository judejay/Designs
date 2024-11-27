using Designs.Behavioural.Visitor;
using Designs.Stuctural_Patterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Abstractions
{
    public interface IEngine : IVisitable
    {
        int Size { get; }
        bool Turbo { get; }

        void Start();
        void Stop();
        void IncreasePower();
        void DecreasePower();

        void Diagnose(IDiagnosticTool tool);

    }
}
