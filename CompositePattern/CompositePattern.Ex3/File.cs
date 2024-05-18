using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace CompositePattern.Ex3
{
    //leaf
    public class File :IData
    {
        private readonly string fileName;

        public File(string fileName,int level)
        {
            string tab = "";
            for (int i = 1; i <= level; i++)
            {
                tab += "\t";
            }
            this.fileName = tab+ fileName;
        }

        public void Print()
        {
            Console.WriteLine(fileName); 

        }
    }
}