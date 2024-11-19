using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Creational_Patterns.Abstract_Factory
{
    public class CarBody: IBody
    {  
            public virtual string BodyParts
            {
                get
                {
                    return "Body shell parts for a car";
                }
        }

    }
}
