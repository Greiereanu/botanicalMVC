using Garden.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    class CSVReport : IReport
    {
        private PlantPersistanceDB plantPersistance = new PlantPersistanceDB();
        public void generate()
        {
            List<Plant> result = plantPersistance.loadPlants();
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
    }
}
