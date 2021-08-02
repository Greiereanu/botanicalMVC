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
    class CLogin
    {
        private LogIn loginView;
        private EmployeePersistance employeePersistance;

        private void handleEvents()
        {
            this.loginView.exitButton().Click += new EventHandler(exitApp);
            this.loginView.loginButton().Click += new EventHandler(loginEmp);
        }

        public LogIn accessLoginView()
        {
            return this.loginView;
        }

        public CLogin()
        {
            this.loginView = new LogIn();
            this.employeePersistance = new EmployeePersistance();
            this.handleEvents();
        }

        private void loginEmp(object sender, EventArgs e)
        {
            EmployeePersistance ep = new EmployeePersistance();
            Employee emp = ep.findEmployee(this.loginView.accountTxt().Text);

            if (emp.getAccount() == "not" || emp.getPassword() != this.loginView.passwordTxt().Text)
            {
                MessageBox.Show("Incorrect username or password");
            }
            else
            {
                if (emp.getRole() == "admin")
                {
                    this.accessLoginView().Hide();
                    CAdmin adminPage = new CAdmin();
                    adminPage.accessAdminView().Show();
                }
                else
                {
                    this.accessLoginView().Hide();
                    CEmployee employeePage = new CEmployee();
                    employeePage.accessEmployeeView().Show();
                }
            }

        }

        private void exitApp(object sender, EventArgs e)
        {
            this.loginView.Hide();
            CVisitor returnPage = new CVisitor();
            returnPage.accessVisitorView().ShowDialog();
        }
    }
}
