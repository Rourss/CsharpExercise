using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class Employee
    {
        private string employeeID;
        private string employeeName;
        private bool sex;
        private DateTime birthday;
        private string brief;
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
       
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
       
        public string Brief
        {
            get { return brief; }
            set { brief = value; }
        }
        public Employee()
        {

        }
        public Employee(string employeeID,string employeeName,bool sex,DateTime birthday,string brief)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.sex = sex;
            this.birthday = birthday;
            this.brief = brief;
        }
    }
}
