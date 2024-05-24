using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class SimpleRemoteControl
    {
        ICommand slot;  //only one button
        public SimpleRemoteControl()
        {

        }
        public void SetCommand(ICommand command)
        {
            // set the command the remote will
            // execute
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}