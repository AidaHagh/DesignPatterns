using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Ex
{
    //  میتونیم به جای ارثبری از ICloneable
    //  خودمون یک اینترفیس درست کنیم و دوتا متد بنویسیم برای شلو و دیپ

    public class Company : ICloneable
    {
        private string companyName;
        private List<Employee> employees = new List<Employee>();

        public string CompanyName
        {
            get => companyName; set => companyName = value;
        }
        public List<Employee> Employees
        {
            get => employees; set => employees = value;
        }

        public object Clone()
        {
            //return this.MemberwiseClone();//shallow copy
            //or //DeepCopy
            // return new Company();

            //چون کانستراکتور نداریم که مقدار از اون بگیره برای دیپ کپی پس بصورت زیر مینویسیم
            Company company = new Company();
            for (int i = 1; i < employees.Count; i++)
            {
                Employee employee = new Employee();
                employee.EmployeeId = employees[i].EmployeeId;
                employee.EmployeeName = employees[i].EmployeeName;
                company.Employees.Add(employee);
            }
            return company; 

        }

        //شبیه سازی بجای دیتابیس
        public void LoadData()
        {
            for (int i = 1; i < 7; i++)
            {
                Employee employee = new Employee();
                employee.EmployeeId = i;
                employee.EmployeeName = "employee" + i.ToString();
                employees.Add(employee);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Company Name Is : * " + CompanyName + "* \n");
            for (int i = 0; i < employees.Count; i++)
            {
                sb.Append("Employee Id And Name Is : " + employees[i].EmployeeId + "," + employees[i].EmployeeName + "\n");
            }
            return sb.ToString();
        }
    }
}
