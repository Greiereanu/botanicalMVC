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
    public partial class EmployeeView : Form
    {

        public EmployeeView()
        {
            InitializeComponent();
        }

        public Button addButton()
        {
            return this.addBtn;
        }

        public Button deleteButton()
        {
            return this.deleteBtn;
        }

        public Button editButton()
        {
            return this.editBtn;
        }

        public Button reportsButton()
        {
            return this.reportBtn;
        }

        public Button exitButton()
        {
            return this.exitBtn;
        }

        public TextBox nameText()
        {
            return this.textBox1;
        }

        public TextBox typeText()
        {
            return this.textBox2;
        }

        public TextBox speciesText()
        {
            return this.textBox3;
        }

        public TextBox carnivorousText()
        {
            return this.textBox4;
        }

        public TextBox zoneText()
        {
            return this.textBox5;
        }

        public DataGridView table()
        {
            return this.dataGridView1;
        }

        public ComboBox selectionCombo()
        {
            return this.comboBox1;
        }

        public Label nameLabel()
        {
            return this.label1;
        }
        public Label typeLabel()
        {
            return this.label2;
        }
        public Label speciesLabel()
        {
            return this.label3;
        }

        public Label carnivorousLabel()
        {
            return this.label4;
        }
        public Label zoneLabel()
        {
            return this.label5;
        }
    }

}
