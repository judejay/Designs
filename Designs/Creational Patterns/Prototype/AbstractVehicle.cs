﻿using Designs.Abstractions;
using Designs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Prototype
{
    public abstract class AbstractVehicle: IVehicle
    {
        private IEngine engine;
        private VehicleColour colour;
        public AbstractVehicle(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }
        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this.engine = engine;
            this.colour = colour;
        }
        public virtual IEngine Engine
        {
            get
            {
                return engine;
            }
        }
        public virtual VehicleColour Colour
        {
            get
            {
                return colour;
            }
        }
        public virtual void Paint(VehicleColour colour)
        {
            this.colour = colour;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + colour + ")";
        }
    }
}