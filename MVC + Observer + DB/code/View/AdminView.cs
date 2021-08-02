using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Garden.View
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
        

        public Button addButton()
        {
            return this.button1;
        }

        public Button removeButton()
        {
            return this.button3;
        }

        public Button editButton()
        {
            return this.button4;
        }

        public Button filterButton()
        {
            return this.button2;
        }

        public Button exitButton()
        {
            return this.button5;
        }

        public TextBox accountText()
        {
            return this.accountTxt;
        }

        public TextBox passwordText()
        {
            return this.passwordTxt;
        }

        public TextBox roleText()
        {
            return this.roleTxt;
        }

        public ComboBox filterSelection()
        {
            return this.comboBox1;
        }

        public DataGridView table()
        {
            return this.dataGridView1;
        }

        public Label accountLabel()
        {
            return this.label1;
        }

        public Label passwordLabel()
        {
            return this.label2;
        }

        public Label roleLabel()
        {
            return this.label3;
        }
    }

}
