using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Interpreter
{
    public class MostNortherlyExpression: IExpression
    {
        private IList<IExpression> _expressions;

        public MostNortherlyExpression(IList<IExpression> expressions)
        {
            _expressions = expressions;
        }

        public virtual City Interpret()
        {
            City resultingCity = new City("Nowhere", -999.9, -999.9);
            foreach (IExpression currentExpression in _expressions)
            {
                City currentCity = currentExpression.Interpret();
                if (currentCity.Latitude > resultingCity.Latitude)
                {
                    resultingCity = currentCity;
                }
            }
            return resultingCity;
        }
    }
}
