using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram.CalculatorExample
{
    public interface ICalculate
    {
        void Calculate(double Number1,double Number2);
    }
}