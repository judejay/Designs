using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Interpreter
{
    public class DirectionalEvaluator
    {
        private IDictionary<string, City> cities;

        public DirectionalEvaluator()
        {
            cities = new Dictionary<string, City>();

            cities["aberdeen"] = new City("Aberdeen", 57.15, -2.15);
            cities["belfast"] = new City("Belfast", 54.62, -5.93);
            cities["birmingham"] = new City("Birmingham", 52.42, -1.92);
            cities["dublin"] = new City("Dublin", 53.33, -6.25);
            cities["edinburgh"] = new City("Edinburgh", 55.92, -3.02);
            cities["glasgow"] = new City("Glasgow", 55.83, -4.25);
            cities["london"] = new City("London", 51.53, -0.08);
            cities["manchester"] = new City("Manchester", 53.5, -2.25);
            cities["southampton"] = new City("Southampton", 50.9, -1.38);
        }

        public virtual City Evaluate(string route)
        {
            //Define the syntax tree
            Stack<IExpression> expressionStack = new Stack<IExpression>();

            //Parse each token in the route string
            foreach (string token in SplitTokens(route))
            {
                // Is the token a city?
                if (cities.ContainsKey(token))
                {
                    expressionStack.Push(new CityExpression(cities[token]));
                }
                // Is the token to find most northerly?

                else if (token.Equals("northerly"))
                {
                    expressionStack.Push(new MostNortherlyExpression(LoadExpressions(expressionStack)));
                }

                // Is the token to find most southerly?
                else if (token.Equals("southerly"))
                {
                    expressionStack.Push(new MostSoutherlyExpression(LoadExpressions(expressionStack)));
                }
                // Is the token to find most easterly?
                else if (token.Equals("easterly"))
                {
                    expressionStack.Push(new MostEasterlyExpression(LoadExpressions(expressionStack)));
                }

                // Is the token to find most westerly?
                else if (token.Equals("westerly"))
                {
                    expressionStack.Push(new MostWesterlyExpression(LoadExpressions(expressionStack)));
                }
            }
            // resulting value
            return expressionStack.Pop().Interpret();
        }

        // Split the route string into individual tokens
        private IList<string> SplitTokens(string str)
        {
            IList<string> tokens = new List<string>();
            int fromIndex = 0;
            bool finished = false;
            while (!finished)
            {
                int spaceLocation = str.IndexOf(' ', fromIndex);
                if (spaceLocation > 0)
                {
                    tokens.Add(str.Substring(fromIndex, spaceLocation - fromIndex));
                    fromIndex = spaceLocation + 1;
                }
                else
                {
                    tokens.Add(str.Substring(fromIndex));
                    finished = true;
                }
            }
            return tokens;
        }


        // Load the expressions from the stack

        private IList<IExpression> LoadExpressions(Stack<IExpression> expressionStack)
        {
            IList<IExpression> expressions = new List<IExpression>();
            while (expressionStack.Count > 0)
            {
                expressions.Add(expressionStack.Pop());
            }
            expressions.Reverse();
            return expressions;
        }

    }
}