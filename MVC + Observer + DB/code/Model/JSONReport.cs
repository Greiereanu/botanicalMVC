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
    class JSONReport : IReport
    {
        private PlantPersistanceDB plantPersistance = new PlantPersistanceDB();
        public void generate()
        {
            List<Plant> result = plantPersistance.loadPlants();
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
