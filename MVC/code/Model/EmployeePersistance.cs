using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Garden.Model
{
    class EmployeePersistance
    {
        protected string path = "../../data/output.xml";

        public List<Employee> loadEmployees()
        {
            XmlDocument xdoc = new XmlDocument();
            List<Employee> result = new List<Employee>();
            xdoc.Load(path);
            XmlNodeList employees = xdoc.SelectNodes("/employees/employee");
            foreach(XmlNode employee in employees)
            {
                try
                {
                    string account = employee.SelectSingleNode("account").InnerText;
                    string password = employee.SelectSingleNode("password").InnerText;
                    string role = employee.SelectSingleNode("role").InnerText;
                    Employee e = new Employee(role, account, password);
                    result.Add(e);
                }
                catch
                {
                    Console.WriteLine("Eroare la citirea datelor din fisierul XML");
                }
            }
            return result;
        }
        public void saveEmployees(List<Employee> employees)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("employees");
            xmlDoc.AppendChild(rootNode);

            foreach (Employee emp in employees)
            {
                XmlNode empData = xmlDoc.CreateElement("employee");
                rootNode.AppendChild(empData);
                XmlNode empAccount = xmlDoc.CreateElement("account");
                empAccount.InnerText = emp.getAccount();
                XmlNode empPassword = xmlDoc.CreateElement("password");
                empPassword.InnerText = emp.getPassword();
                XmlNode empRole = xmlDoc.CreateElement("role");
                empRole.InnerText = emp.getRole();
                empData.AppendChild(empAccount);
                empData.AppendChild(empPassword);
                empData.AppendChild(empRole);
            }
            xmlDoc.Save(path);
      
        }

        public void saveEmployee(Employee employee)
        {
            List<Employee> result = new List<Employee>();
            result = this.loadEmployees();
            bool exists = false;
            foreach (Employee e in result){
                if (e.getAccount() == employee.getAccount())
                    exists = true;
            }
            if (!exists)
            {
                result.Add(employee);
                this.saveEmployees(result);
            }
        }

        public void deleteEmployee(Employee employee)
        {
            List<Employee> result = new List<Employee>();
            result = this.loadEmployees();
            foreach (Employee e in result)
            {
                if (e.getAccount() == employee.getAccount())
                {
                    result.Remove(e);
                    break;
                }
            }
            this.saveEmployees(result);

        }

        public void editEmployee(Employee oldEmployee, Employee newEmployee)
        {
            List<Employee> result = new List<Employee>();
            result = this.loadEmployees();
            foreach (Employee e in result)
            {
                if (e.getAccount() == oldEmployee.getAccount())
                {
                    result.Remove(e);
                    result.Add(newEmployee);
                    break;
                }
            }
            this.saveEmployees(result);
        }

        public Employee findEmployee(string account)
        {
            List<Employee> result = new List<Employee>();
            result = this.loadEmployees();
            foreach (Employee e in result)
            {
                if (account == e.getAccount())
                    return e;
            }
                return new Employee("-","not", "found");
        }

        public List<Employee> filterEmployees(string role)
        {
            List<Employee> result = new List<Employee>();
            List<Employee> filter = new List<Employee>();
            result = this.loadEmployees();
            foreach(Employee e in result)
            {
                if (role == e.getRole())
                    filter.Add(e);
            }
            return filter;
        }
    }

    
}
