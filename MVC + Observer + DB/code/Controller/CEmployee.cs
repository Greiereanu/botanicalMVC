using Garden.Model;
using Garden.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    class CEmployee
    {
        private EmployeeView employeeView;
        private PlantPersistanceDB plantPersistance;
        int language = 1;
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

        public void changeLanguage(int languageID)
        {
            language = languageID;
            switch (languageID)
            {
                case 1:
                    this.employeeView.exitButton().Text = "Iesire";
                    this.employeeView.addButton().Text = "Adaugare";
                    this.employeeView.deleteButton().Text = "Stergere";
                    this.employeeView.editButton().Text = "Editare";
                    this.employeeView.reportsButton().Text = "Rapoarte";

                    this.employeeView.nameLabel().Text = "Nume";
                    this.employeeView.typeLabel().Text = "Tip";
                    this.employeeView.speciesLabel().Text = "Specie";
                    this.employeeView.carnivorousLabel().Text = "Carnivora";
                    this.employeeView.zoneLabel().Text = "Zona";
                    break;

                case 2:
                    this.employeeView.exitButton().Text = "Exit";
                    this.employeeView.addButton().Text = "Add";
                    this.employeeView.deleteButton().Text = "Delete";
                    this.employeeView.editButton().Text = "Edit";
                    this.employeeView.reportsButton().Text = "Reports";

                    this.employeeView.nameLabel().Text = "Name";
                    this.employeeView.typeLabel().Text = "Type";
                    this.employeeView.speciesLabel().Text = "Species";
                    this.employeeView.carnivorousLabel().Text = "Carnivorous";
                    this.employeeView.zoneLabel().Text = "Zone";
                    break;

                case 3:
                    this.employeeView.exitButton().Text = "Sortir";
                    this.employeeView.addButton().Text = "Ajouter";
                    this.employeeView.deleteButton().Text = "Effacer";
                    this.employeeView.editButton().Text = "Editer";
                    this.employeeView.reportsButton().Text = "Rapports";

                    this.employeeView.nameLabel().Text = "Nom";
                    this.employeeView.typeLabel().Text = "Taper";
                    this.employeeView.speciesLabel().Text = "Espece";
                    this.employeeView.carnivorousLabel().Text = "Carnivore";
                    this.employeeView.zoneLabel().Text = "Zone";
                    break;

                case 4:
                    this.employeeView.exitButton().Text = "Ausfahrt";
                    this.employeeView.addButton().Text = "Hinzufugen";
                    this.employeeView.deleteButton().Text = "Loschen";
                    this.employeeView.editButton().Text = "Bearbeiten";
                    this.employeeView.reportsButton().Text = "Berichte";

                    this.employeeView.nameLabel().Text = "Name";
                    this.employeeView.typeLabel().Text = "Art";
                    this.employeeView.speciesLabel().Text = "Spezies";
                    this.employeeView.carnivorousLabel().Text = "Fleischfresser";
                    this.employeeView.zoneLabel().Text = "Zone";
                    break;
            }
        }
        public CEmployee(int languageID)
        {
            this.employeeView = new EmployeeView();
            this.plantPersistance = new PlantPersistanceDB();
            this.handleEvents();
            this.ShowInfo();
            this.changeLanguage(languageID);
        }

        private void exitApp(object sender, EventArgs e)
        {
            this.employeeView.Hide();
            CVisitor returnPage = new CVisitor(language);
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
            ReportFactory factory = new ConcreteReportFactory();
            IReport report = factory.getReport(this.employeeView.selectionCombo().Text);
            report.generate();
        }

    }
}
