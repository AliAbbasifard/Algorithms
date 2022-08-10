using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Two_Stack_Algorithm
{
    internal static class Algorithm
    {
        public static double Run(string expression)
        {
            var numberStack = new Stack<double>();
            var symbolStack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var value = expression[i];
                if (value == ')')
                {
                    var first = numberStack.Pop();
                    var second = numberStack.Pop();

                    var symbol = symbolStack.Pop();

                    if (symbol == '+')
                        numberStack.Push(first + second);
                    else if (symbol == '-')
                        numberStack.Push(first - second);
                    else if (symbol == '*')
                        numberStack.Push(first * second);
                    else
                        numberStack.Push(first / second);
                }
                else if (value == '*' || value == '+' || value == '-' || value == '/')
                    symbolStack.Push(value);
                else if (value == '(' || value == ' ')
                    continue;
                else
                    numberStack.Push(char.GetNumericValue(value));
            }


            return numberStack.Pop();
        }
    }
}
