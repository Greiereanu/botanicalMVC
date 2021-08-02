using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden.Model
{
    class Plant
    {
        [JsonProperty]
        protected string name { get; set; }
        [JsonProperty]
        protected string type { get; set; }
        [JsonProperty]
        protected string species { get; set; }
        [JsonProperty]
        protected string isCarnivorous { get; set; }
        [JsonProperty]
        protected string gardenZone { get; set; }

        public string getName()
        {
            return this.name;
        }
       
        public string getType()
        {
            return this.type;
        }

        public string getSpecies()
        {
            return this.species;
        }

        public string getIsCarnivorous()
        {
            return this.isCarnivorous;
        }

        public string getGardenZone()
        {
            return this.gardenZone;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setSpecies(string species)
        {
            this.species = species;
        }

        public void setIsCarnivorous(string isCarnivorous)
        {
            this.isCarnivorous = isCarnivorous;
        }

        public void setGardenZone(string gardenZone)
        {
            this.gardenZone = gardenZone;
        }

        public Plant()
        {
            this.name = "";
            this.type = "";
            this.isCarnivorous = "";
            this.species = "";
            this.gardenZone = "";
        }

        public Plant(string name, string type, string species, string isCarnivorous, string gardenZone)
        {
            this.name = name;
            this.type = type;
            this.species = species;
            this.isCarnivorous = isCarnivorous;
            this.gardenZone = gardenZone;
        }

        public Plant(Plant plant)
        {
            this.name = plant.name;
            this.type = plant.type;
            this.species = plant.species;
            this.isCarnivorous = plant.isCarnivorous;
            this.gardenZone = plant.gardenZone;
        }

        public string showInfo()
        {
            return String.Format("Name: {0}\n Type: {1}\n Species: {2}\n Is Carnivorous: {3}\nGarden Zone: {4}\n", this.name, this.type, this.species, this.isCarnivorous, this.gardenZone);
        }
    }
}
