using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram.CarExample
{
    public class Bmw : ICar
    {
        public void Start()
        {
            Console.WriteLine("Bmw Is Starting...");
        }
    }
}