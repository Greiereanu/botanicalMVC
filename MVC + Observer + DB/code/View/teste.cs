using Garden.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class teste : Form
    {
        PlantPersistanceDB pdb = new PlantPersistanceDB();
        public teste()
        {
            InitializeComponent();
            
        }
        private void teste_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Plant> test = pdb.loadPlants();
            foreach(Plant p in test)
            {
                Console.WriteLine(p.showInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plant p1 = new Plant("Flytrap", "draci", "", "False", "east");
            Plant p2 = new Plant("Flytrap", "", "", "", "");
            pdb.editPlant(p2, p1);
        }
    }
}
