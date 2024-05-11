using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Ex1
{
    public class House
    {
        private string foundation;
        private string structure;
        private string roof;
        private bool painted;
        private bool furnished;

        public string Foundation
        {
            set { foundation = value; }
        }
        public string Structure
        {
            set { structure = value; }
        }
        public string Roof
        {
            set { roof = value; }
        }

        public bool Painted
        {
            set { painted = value; }
        }

        public bool Furnished
        {
            set { furnished = value; }
        }

        public override string ToString()
        {
            return "/Foundation : " + foundation + "/ Structure : " + structure + "/ Roof : " + roof + "/ Is Painted ? " + painted + "/ Is Furnished ? " + furnished;
        }
    }
}