using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Ex
{
    public class Employee
    {
        private int employeeId;
        private string employeeName;

        public int EmployeeId
        {
            get => employeeId; set => employeeId = value; 
        }
        public string EmployeeName 
        {
            get => employeeName; set => employeeName = value;
        }

        public override string ToString()
        {
            return "EmployeeDetail : Id Is [" + employeeId +"] and Name is : * " + employeeName + " * ";
        }
    }
}
