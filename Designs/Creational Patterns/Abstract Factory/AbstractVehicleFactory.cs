﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Abstract_Factory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IChassis CreateChassis();
        public abstract IBody CreateBody();
        public abstract IGlassware CreateGlassware();

    }
}