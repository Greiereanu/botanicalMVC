using Garden.Model;
using Garden.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    class CEmployee
    {
        private EmployeeView employeeView;
        private PlantPersistance plantPersistance;

        public EmployeeView accessEmployeeView()
        {
            return this.employeeView;
        }

        public void ShowInfo()
        {
            List<Plant> result = plantPersistance.loadPlants();
            foreach (Plant plant in result)
                this.employeeView.table().Rows.Add(plant.getName(), plant.getType(), plant.getSpecies(), plant.getIsCarnivorous(), plant.getGardenZone());
        }

        private void handleEvents()
        {
            this.employeeView.exitButton().Click += new EventHandler(exitApp);
            this.employeeView.addButton().Click += new EventHandler(addPlant);
            this.employeeView.deleteButton().Click += new EventHandler(deletePlant);
            this.employeeView.editButton().Click += new EventHandler(editPlant);
            this.employeeView.reportsButton().Click += new EventHandler(generateReports);
        }
        public CEmployee()
        {
            this.employeeView = new EmployeeView();
            this.plantPersistance = new PlantPersistance();
            this.handleEvents();
            this.ShowInfo();
        }

        private void exitApp(object sender, EventArgs e)
        {
            this.employeeView.Hide();
            CVisitor returnPage = new CVisitor();
            returnPage.accessVisitorView().ShowDialog();
        }

        public void addPlant(object sender, EventArgs e)
        {
            if (this.employeeView.nameText().Text == "" || this.employeeView.typeText().Text == "" || this.employeeView.speciesText().Text == "" || this.employeeView.carnivorousText().Text == "" || this.employeeView.zoneText().Text == "")
            {
                MessageBox.Show("You must enter data in all of those fields!");
            }
            else
            {
                Plant p = new Plant(this.employeeView.nameText().Text, this.employeeView.typeText().Text, this.employeeView.speciesText().Text, this.employeeView.carnivorousText().Text, this.employeeView.zoneText().Text);
                plantPersistance.savePlant(p);
                this.employeeView.table().Rows.Clear();
                this.employeeView.table().Refresh();
                this.ShowInfo();

            }
        }

        public void deletePlant(object sender, EventArgs e)
        {
            if (this.employeeView.nameText().Text == "")
            {
                MessageBox.Show("In order to delete a plant, enter its name!");
            }
            else
            {
                Plant p = plantPersistance.findPlant(this.employeeView.nameText().Text);
                if (p.getName() == "not")
                {
                    MessageBox.Show("That plant doesn't exist!");
                }
                else
                {
                    plantPersistance.deletePlant(p);
                    this.employeeView.table().Rows.Clear();
                    this.employeeView.table().Refresh();
                    this.ShowInfo();
                }
            }
        }

        public void editPlant(object sender, EventArgs e)
        {
            List<Plant> result = plantPersistance.loadPlants();
            Plant p = plantPersistance.findPlant(this.employeeView.nameText().Text);
            if (p.getName() == "not")
            {
                MessageBox.Show("That plant doesn't exist!");
            }
            else
            {
                if (this.employeeView.typeText().Text == "" || this.employeeView.speciesText().Text == "" || this.employeeView.carnivorousText().Text == "" || this.employeeView.zoneText().Text == "")
                {
                    MessageBox.Show("You must provide all the data before editing!");
                }
                else
                {
                    Plant newPlant = new Plant(this.employeeView.nameText().Text, this.employeeView.typeText().Text, this.employeeView.speciesText().Text, this.employeeView.carnivorousText().Text, this.employeeView.zoneText().Text);
                    plantPersistance.editPlant(p, newPlant);
                }
            }

            this.employeeView.table().Rows.Clear();
            this.employeeView.table().Refresh();
            List<Plant> after = plantPersistance.loadPlants();
            foreach (Plant plant in after)
                this.employeeView.table().Rows.Add(plant.getName(), plant.getType(), plant.getSpecies(), plant.getIsCarnivorous(), plant.getGardenZone());
        }


        public void generateReports(object sender, EventArgs e)
        {
            List<Plant> result = plantPersistance.loadPlants();

            if (this.employeeView.selectionCombo().Text == "CSV")
            {
                var filepath = "../../data/CSV_Report.csv";
                using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                FileMode.Create, FileAccess.Write)))
                {
                    string fields = String.Format("Name,Type,Species,IsCarnivorous,Zone");
                    writer.WriteLine(fields);
                    foreach (Plant p in result)
                    {
                        string info = String.Format("{0},{1},{2},{3},{4}", p.getName(), p.getType(), p.getSpecies(), p.getIsCarnivorous(), p.getGardenZone());
                        writer.WriteLine(info);
                    }
                }

                MessageBox.Show("CSV Report generated succesfully!");
            }
            if (this.employeeView.selectionCombo().Text == "JSON")
            {
                var filepath = "../../data/JSON_Report.json";
                using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                FileMode.Create, FileAccess.Write)))
                {
                    foreach (Plant p in result)
                    {
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(p);
                        writer.WriteLine(json);
                    }
                }
                MessageBox.Show("JSON Report generated succesfully!");
            }
        }

    }
}
