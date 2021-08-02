using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Garden.Model;

namespace Garden.View
{
    public partial class VisitorView : Form
    {
        public VisitorView()
        {
            InitializeComponent();
        }

        public Button loginButton()
        {
            return this.button1;
        }

        public Button exitButton()
        {
            return this.button2;
        }
        public Button searchButton()
        {
            return this.searchBtn;
        }

        public Button statsButton()
        {
            return this.statsBtn;
        }
        public Button filterButton()
        {
            return this.filterBtn;
        }
        //LANGUAGES
        public Button romanaButton()
        {
            return this.romanaBtn;
        }

        public Button engButton()
        {
            return this.englishBtn;
        }

        public Button frButton()
        {
            return this.frBtn;
        }

        public Button deButton()
        {
            return this.deBtn;
        }




        public TextBox searchText()
        {
            return this.searchTxt;
        }

        public TextBox filterText()
        {
            return this.filterTxt;
        }

        public ComboBox filterCmb()
        {
            return this.filterCombo;
        }

        public ComboBox statsCmb()
        {
            return this.statsCombo;
        }

        public DataGridView table()
        {
            return this.dataGridView1;
        }

        public Chart charts()
        {
            return this.statistics;
        }

    }
}
