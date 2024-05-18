using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Ex2
{
    public class Manager :IEmployee
    {
        private string position;
        private string name;
        private int employeeId;

        public Manager(string position, string name, int employeeId)
        {
            this.position = position;
            this.name = name;
            this.employeeId = employeeId;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Id:"+employeeId+" "+name+" "+position);
        }
    }
}