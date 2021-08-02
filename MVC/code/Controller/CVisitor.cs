using Garden.Model;
using Garden.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1.Controller
{
    class CVisitor
    {
        private VisitorView visitorView;
        private PlantPersistance plantPersistance;
        private void handleEvents()
        {
            this.visitorView.exitButton().Click += new EventHandler(exitApp);
            this.visitorView.searchButton().Click += new EventHandler(findPlant);
            this.visitorView.filterButton().Click += new EventHandler(filterPlants);
            this.visitorView.statsButton().Click += new EventHandler(showStatistics);
            this.visitorView.loginButton().Click += new EventHandler(showLogin);

        }

        private void ShowInfo()
        {
            List<Plant> result = plantPersistance.loadPlants();
            foreach (Plant plant in result)
                this.visitorView.table().Rows.Add(plant.getName(), plant.getType(), plant.getSpecies(), plant.getIsCarnivorous(), plant.getGardenZone());
        }

        public VisitorView accessVisitorView()
        {
            return this.visitorView;
        }

        public CVisitor()
        {
            this.visitorView = new VisitorView();
            this.plantPersistance = new PlantPersistance();
            this.handleEvents();
            this.ShowInfo();
        }

        private void exitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void findPlant(object sender, EventArgs e)
        {
            Plant p = plantPersistance.findPlant(this.visitorView.searchText().Text);
            if (p.getName() == "not")
            {
                var info = String.Format("Plant {0} does not exist!", this.visitorView.searchText().Text);
                MessageBox.Show(info, "Plant Info");
            }
            else
            {
                MessageBox.Show(p.showInfo(), "Plant Info");
            }
        }

        public void filterPlants(object sender, EventArgs e)
        {
            List<Plant> filter = plantPersistance.filterPlants(this.visitorView.filterCmb().Text, this.visitorView.filterText().Text);
            this.visitorView.table().Rows.Clear();
            this.visitorView.table().Refresh();
            foreach (Plant plant in filter)
            {
                this.visitorView.table().Rows.Add(plant.getName(), plant.getType(), plant.getSpecies(), plant.getIsCarnivorous(), plant.getGardenZone());
            }
        }

        public void showStatistics(object sender, EventArgs e)
        {
            List<Plant> plants = plantPersistance.loadPlants();
            if (this.visitorView.statsCmb().Text == "Carnivorous")
            {
                int number1 = 0, number2 = 0;
                foreach (Plant p in plants)
                {
                    if (p.getIsCarnivorous() == "True")
                        number1++;
                    else
                        number2++;
                }
                Chart chart1 = this.visitorView.charts();
                chart1.Series.Clear();
                chart1.Legends.Clear();
                chart1.Legends.Add("MyLegend");
                chart1.Legends[0].LegendStyle = LegendStyle.Table;
                chart1.Legends[0].Docking = Docking.Bottom;
                chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
                chart1.Legends[0].Title = "Tipul plantelor";
                chart1.Legends[0].BorderColor = System.Drawing.Color.Black;

                //Add a new chart-series
                string seriesname = "MySeriesName";
                chart1.Series.Add(seriesname);
                //set the chart-type to "Pie"
                chart1.Series[seriesname].ChartType = SeriesChartType.Pie;


                chart1.Series[seriesname].Points.AddXY("Carnivore", number1);
                chart1.Series[seriesname].Points.AddXY("Non-Carnivore", number2);
                chart1.Series[seriesname].IsValueShownAsLabel = true;

                chart1.Visible = true;
            }
            if (this.visitorView.statsCmb().Text == "Zone")
            {
                int north = 0; int south = 0; int west = 0; int east = 0;
                foreach (Plant p in plants)
                {
                    if (p.getGardenZone() == "north")
                        north++;
                    if (p.getGardenZone() == "south")
                        south++;
                    if (p.getGardenZone() == "west")
                        west++;
                    if (p.getGardenZone() == "east")
                        east++;
                    Chart chart1 = this.visitorView.charts();
                    chart1.Series.Clear();
                    chart1.Legends.Clear();
                    chart1.Legends.Add("MyLegend");
                    chart1.Legends[0].LegendStyle = LegendStyle.Table;
                    chart1.Legends[0].Docking = Docking.Bottom;
                    chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
                    chart1.Legends[0].Title = "Garden Zone";
                    chart1.Legends[0].BorderColor = System.Drawing.Color.Black;

                    string seriesname = "Zone";
                    chart1.Series.Add(seriesname);
                    //set the chart-type to "Pie"
                    chart1.Series[seriesname].ChartType = SeriesChartType.Column;

                    chart1.Series[seriesname].Points.AddXY("North", north);
                    chart1.Series[seriesname].Points.AddXY("South", south);
                    chart1.Series[seriesname].Points.AddXY("East", east);
                    chart1.Series[seriesname].Points.AddXY("West", west);
                    chart1.Series[seriesname].IsValueShownAsLabel = true;
                    chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                    chart1.Visible = true;

                }
            }

        }

        public void showLogin(object sender, EventArgs e)
        {
            this.visitorView.Hide();
            CLogin loginView = new CLogin();
            loginView.accessLoginView().Show();
        }
    }
}

