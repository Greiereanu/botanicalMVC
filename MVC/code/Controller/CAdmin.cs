using Garden.Model;
using Garden.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    class CAdmin
    {
        private AdminView adminView;
        private EmployeePersistance employeePersistance = new EmployeePersistance();

        public AdminView accessAdminView()
        {
            return this.adminView;
        }

        private void handleEvents()
        {
            this.adminView.exitButton().Click += new EventHandler(exitApp);
            this.adminView.addButton().Click += new EventHandler(addEmployee);
            this.adminView.removeButton().Click += new EventHandler(deleteEmployee);
            this.adminView.filterButton().Click += new EventHandler(filterEmployees);
            this.adminView.editButton().Click += new EventHandler(editEmployee);
        }
        public CAdmin()
        {
            this.adminView = new AdminView();
            this.employeePersistance = new EmployeePersistance();
            this.handleEvents();
            this.ShowInfo();
        }

        private void exitApp(object sender, EventArgs e)
        {
            this.adminView.Hide();
            CVisitor returnPage = new CVisitor();
            returnPage.accessVisitorView().ShowDialog();
        }

        public void ShowInfo()
        {
            List<Employee> result = employeePersistance.loadEmployees();
            foreach (Employee emp in result)
                this.adminView.table().Rows.Add(emp.getAccount(), emp.getPassword(), emp.getRole());
        }

        public void refreshInfo()
        {
            this.adminView.table().Rows.Clear();
            this.adminView.table().Refresh();
            this.ShowInfo();
        }

        public void addEmployee(object sender, EventArgs e)
        {
            if (this.adminView.accountText().Text == "" || this.adminView.passwordText().Text == "" || this.adminView.roleText().Text == "")
            {
                MessageBox.Show("You must enter data in all of those fields!");
            }
            else
            {
                Employee emp = new Employee(this.adminView.roleText().Text, this.adminView.accountText().Text, this.adminView.passwordText().Text);
                employeePersistance.saveEmployee(emp);
                this.refreshInfo();
            }
        }


        public void deleteEmployee(object sender, EventArgs e)
        {

            if (this.adminView.accountText().Text == "")
            {
                MessageBox.Show("In order to delete an employee, enter his account!");
            }
            else
            {
                Employee emp = employeePersistance.findEmployee(this.adminView.accountText().Text);
                if (emp.getAccount() == "not")
                {
                    MessageBox.Show("That users doesn't exist!");
                }
                else
                {
                    employeePersistance.deleteEmployee(emp);
                    this.refreshInfo();
                }
            }
        }

        public void filterEmployees(object sender, EventArgs e)
        {
            List<Employee> result = employeePersistance.filterEmployees(this.adminView.filterSelection().Text);

            this.adminView.table().Rows.Clear();
            this.adminView.table().Refresh();
            foreach (Employee emp in result)
                this.adminView.table().Rows.Add(emp.getAccount(), emp.getPassword(), emp.getRole());
        }

        public void editEmployee(object sender, EventArgs e)
        {
            List<Employee> result = employeePersistance.loadEmployees();
            Employee emp = employeePersistance.findEmployee(this.adminView.accountText().Text);
            if (emp.getAccount() == "not")
            {
                MessageBox.Show("That users doesn't exist!");
            }
            else
            {
                if (this.adminView.passwordText().Text == "" || this.adminView.roleText().Text == "")
                {
                    MessageBox.Show("You must provide that user a password and a role!");
                }
                else
                {
                    Employee newEmployee = new Employee(this.adminView.roleText().Text, this.adminView.accountText().Text, this.adminView.passwordText().Text);
                    employeePersistance.editEmployee(emp, newEmployee);
                }
            }

            this.adminView.table().Rows.Clear();
            this.adminView.table().Refresh();
            List<Employee> after = employeePersistance.loadEmployees();
            foreach (Employee empNew in after)
                this.adminView.table().Rows.Add(empNew.getAccount(), empNew.getPassword(), empNew.getRole());
        }
    }
}
