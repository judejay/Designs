using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Interpreter
{
    public class MostSoutherlyExpression : IExpression
    {
        private IList<IExpression> _cityExpressions;

        public MostSoutherlyExpression(IList<IExpression> expressions)
        {
            _cityExpressions = expressions;

        }

        public virtual City Interpret()
        {
            City resultingCity = new City("Nowhere", 999.9, 999.9);
            foreach (IExpression currentExpression in _cityExpressions)
            {
                City currentCity = currentExpression.Interpret();
                if (currentCity.Latitude < resultingCity.Latitude)
                {
                    resultingCity = currentCity;
                }
            }
            return resultingCity;
        }
    }
}
