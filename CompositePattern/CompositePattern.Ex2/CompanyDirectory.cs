using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Ex2
{
    //composite
    public class CompanyDirectory : IEmployee
    {
        private List<IEmployee> employees = new List<IEmployee>();
        public void ShowEmployeeDetails()
        {
            foreach (IEmployee employee in employees)
            {
                employee.ShowEmployeeDetails();
            }
        }

        public void Add(IEmployee employee)
        {
            employees.Add(employee);    
        }

        public void Remove(IEmployee employee)
        {
            employees.Remove(employee); 
        }
    }
}