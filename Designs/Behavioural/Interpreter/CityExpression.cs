using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Interpreter
{
    public class CityExpression : IExpression
    {
        private City _city;

        public CityExpression(City city)
        {
            _city = city;
        }

        public virtual City Interpret()
        {
            return _city;
        }
    }
}
