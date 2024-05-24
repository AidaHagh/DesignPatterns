using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex2
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}