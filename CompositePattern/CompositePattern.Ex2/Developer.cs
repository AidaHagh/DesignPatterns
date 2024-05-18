using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Ex2
{
    public class Developer : IEmployee
    {
        private int employeeId;
        private string name;
        private string position;

        public Developer(int employeeId, string name, string position)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.position = position;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Id:" + employeeId + " " + name + " " + position);
        }
    }
}