using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Garden.Model
{
    class PlantPersistance
    {
        protected string path = "../../data/plants.xml";
        public List<Plant> loadPlants()
        {
            XmlDocument xdoc = new XmlDocument();
            List<Plant> result = new List<Plant>();
            xdoc.Load(path);
            XmlNodeList plants = xdoc.SelectNodes("/plants/plant");
            foreach (XmlNode plant in plants)
            {
                try
                {

                    string name = plant.SelectSingleNode("name").InnerText;
                    string type = plant.SelectSingleNode("type").InnerText;
                    string species = plant.SelectSingleNode("species").InnerText;
                    string isCarnivorous = plant.SelectSingleNode("isCarnivorous").InnerText;
                    string gardenZone = plant.SelectSingleNode("gardenZone").InnerText;
                    Plant p = new Plant(name, type, species, isCarnivorous, gardenZone);
                    result.Add(p);
                }
                catch
                {
                    Console.WriteLine("Eroare la citirea datelor din fisierul XML");
                }
            }
            return result;
        }

        public void savePlants(List<Plant> plants)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("plants");
            xmlDoc.AppendChild(rootNode);

            foreach (Plant plant in plants)
            {
                XmlNode plantData = xmlDoc.CreateElement("plant");
                rootNode.AppendChild(plantData);
                XmlNode plantName = xmlDoc.CreateElement("name");
                plantName.InnerText = plant.getName();

                XmlNode plantType = xmlDoc.CreateElement("type");
                plantType.InnerText = plant.getType();

                XmlNode plantSpecies = xmlDoc.CreateElement("species");
                plantSpecies.InnerText = plant.getSpecies();

                XmlNode plantCarnivorous = xmlDoc.CreateElement("isCarnivorous");
                plantCarnivorous.InnerText = plant.getIsCarnivorous().ToString();


                XmlNode plantZone = xmlDoc.CreateElement("gardenZone");
                plantZone.InnerText = plant.getGardenZone();

                plantData.AppendChild(plantName);
                plantData.AppendChild(plantType);
                plantData.AppendChild(plantSpecies);
                plantData.AppendChild(plantCarnivorous);
                plantData.AppendChild(plantZone);
            }
            xmlDoc.Save(path);

        }

        public void savePlant(Plant plant)
        {
            List<Plant> result = new List<Plant>();
            result = this.loadPlants();
            bool exists = false;
            foreach (Plant p in result)
            {
                if (p.getName() == plant.getName())
                    exists = true;
            }
            if (!exists)
            {
                result.Add(plant);
                this.savePlants(result);
            }
        }

        public void deletePlant(Plant plant)
        {
            List<Plant> result = new List<Plant>();
            result = this.loadPlants();
            foreach (Plant p in result)
            {
                if (p.getName() == plant.getName())
                {
                    result.Remove(p);
                    break;
                }
            }
            this.savePlants(result);

        }

        public Plant findPlant(string plant)
        {
            List<Plant> result = new List<Plant>();
            result = this.loadPlants();
            foreach (Plant p in result)
            {
                if (plant == p.getName())
                    return p;
            }
            return new Plant("not", "found", "!", "", "");
        }

        public void editPlant(Plant oldPlant, Plant newPlant)
        {
            List<Plant> result = new List<Plant>();
            result = this.loadPlants();
            foreach (Plant p in result)
            {
                if (p.getName() == oldPlant.getName())
                {
                    result.Remove(p);
                    result.Add(newPlant);
                    break;
                }
            }
            this.savePlants(result);
        }

        public List<Plant> filterPlants(string criteria, string value)
        {
            List<Plant> result = new List<Plant>();
            List<Plant> filter = new List<Plant>();
            result = this.loadPlants();
            if (value == "")
                return result;
            foreach (Plant p in result)
            {
                switch(criteria)
                {
                    case "name":
                        if (p.getName() == value)
                            filter.Add(p);
                        break;

                    case "type":
                        if (p.getType() == value)
                            filter.Add(p);
                        break;

                    case "species":
                        if (p.getSpecies() == value)
                            filter.Add(p);
                        break;

                    case "isCarnivorous":
                        if (p.getIsCarnivorous().ToString() == value)
                            filter.Add(p);
                        break;

                    case "Zone":
                        if (p.getGardenZone() == value)
                            filter.Add(p);
                        break;

                    default:
                        break;
                }

            }
            return filter;
        }
    }
}
