using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garden.Model;

namespace Garden.View
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public Button loginButton()
        {
            return this.loginBtn;
        }

        public Button exitButton()
        {
            return this.exitBtn;
        }

        public TextBox accountTxt()
        {
            return this.accountText;
        }

        public TextBox passwordTxt()
        {
            return this.PasswordText;
        }

        public Label accountLabel()
        {
            return this.label1;
        }

        public Label passwordLabel()
        {
            return this.label2;
        }
    }

}
