﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Abstract_Factory
{
    public class VanGlassware: IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Glassware parts for a van";
            }
        }
    }
}
