using FactoryPatternWithClassDiagram.CalculatorExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram
{
    public class CalculateFactory
    {
        public ICalculate GetCaculation(string type)
        {
            ICalculate calculate = null;

            if (type.ToLower() == "divide")
            {
                calculate = new Divide();
            }
            else if (type.ToLower() == "plus")
            {
                calculate = new Plus();
            }else if (type.ToLower() == "minus")
            {
                calculate = new Minus();
            }
            else if (type.ToLower() == "multiple")
            {
                calculate = new Multiple();
            }
          return calculate;

        }
    }
}