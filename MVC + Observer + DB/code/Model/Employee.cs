using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden.Model
{
    class Employee
    {
        protected string role { get; set; }
        protected string account { get; set; }
        protected string password { get; set; }

        public string getRole()
        {
            return this.role;
        }
        public string getAccount()
        {
            return this.account;
        }
        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setAccount(string account)
        {
            this.account = account;
        }
        public void setRole(string role)
        {
            this.role = role;
        }

        public Employee()
        {
            this.role = "";
            this.account = "";
            this.password = "";
        }

        public Employee(string role, string account, string password)
        {
            this.role = role;
            this.account = account;
            this.password = password;
        }

        public Employee(Employee employee)
        {
            this.role = employee.role;
            this.account = employee.account;
            this.password = employee.password;
        }

        public string ShowInfo()
        {
            return String.Format("ID: {0} Password: {1} Role: {2}", this.account, this.password, this.role);
        }
    }
}
