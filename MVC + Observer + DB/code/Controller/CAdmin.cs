using Garden.Model;
using Garden.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    class CAdmin
    {
        private AdminView adminView;
        private EmployeePersistanceDB employeePersistance;
        int language = 1;
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
        public void changeLanguage(int languageID)
        {
            language = languageID;
            switch (languageID)
            {
                case 1:
                    this.adminView.exitButton().Text = "Iesire";
                    this.adminView.addButton().Text = "Adaugare";
                    this.adminView.removeButton().Text = "Stergere";
                    this.adminView.editButton().Text = "Editare";
                    this.adminView.filterButton().Text = "Filtrare";
                    this.adminView.accountLabel().Text = "Cont";
                    this.adminView.passwordLabel().Text = "Parola";
                    this.adminView.roleLabel().Text = "Rol";
                    break;

                case 2:
                    this.adminView.exitButton().Text = "Exit";
                    this.adminView.addButton().Text = "Add";
                    this.adminView.removeButton().Text = "Delete";
                    this.adminView.editButton().Text = "Edit";
                    this.adminView.filterButton().Text = "Filter";
                    this.adminView.accountLabel().Text = "Account";
                    this.adminView.passwordLabel().Text = "Password";
                    this.adminView.roleLabel().Text = "Role";
                    break;

                case 3:
                    this.adminView.exitButton().Text = "Sortir";
                    this.adminView.addButton().Text = "Ajouter";
                    this.adminView.removeButton().Text = "Effacer";
                    this.adminView.editButton().Text = "Editer";
                    this.adminView.filterButton().Text = "Filtre";
                    this.adminView.accountLabel().Text = "Compte";
                    this.adminView.passwordLabel().Text = "Devise";
                    this.adminView.roleLabel().Text = "Role";
                    break;

                case 4:
                    this.adminView.exitButton().Text = "Ausfahrt";
                    this.adminView.addButton().Text = "Hinzufugen";
                    this.adminView.removeButton().Text = "Loschen";
                    this.adminView.editButton().Text = "Bearbeiten";
                    this.adminView.filterButton().Text = "Filter";
                    this.adminView.accountLabel().Text = "Konto";
                    this.adminView.passwordLabel().Text = "Passwort";
                    this.adminView.roleLabel().Text = "Rolle";
                    break;
            }
        }
        public CAdmin(int languageID)
        {
            this.adminView = new AdminView();
            this.employeePersistance = new EmployeePersistanceDB();
            this.handleEvents();
            this.ShowInfo();
            this.changeLanguage(languageID);
        }

        private void exitApp(object sender, EventArgs e)
        {
            this.adminView.Hide();
            CVisitor returnPage = new CVisitor(language);
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
                Observable observable = new Observable();
                Observer observer = new Observer();
                observable.actionHappened += observer.HandleEvent;
                observable.Notify();
                Console.WriteLine("Location : AdminView Controller");
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
