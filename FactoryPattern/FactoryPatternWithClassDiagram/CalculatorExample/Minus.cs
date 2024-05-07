using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram.CalculatorExample
{
    public class Minus : ICalculate
    {
        public void Calculate(double Number1, double Number2)
        {
            Console.WriteLine(" {0}-{1}={2} :", Number1, Number2, Number1 - Number2);
        }
    }
}