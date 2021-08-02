using Garden.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class PlantPersistanceDB
    {
        //SQLiteConnection sqlite_conn;
        public PlantPersistanceDB()
        {
            //sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;");
        }

        public List<Plant> loadPlants()
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                List<Plant> result = new List<Plant>();
                sqlite_conn.Open();
                SQLiteDataReader reader;
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM plants";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string type = reader.GetString(1);
                    string species = reader.GetString(2);
                    string carnivorous = reader.GetString(3);
                    string zone = reader.GetString(4);
                    Plant plant = new Plant(name, type, species, carnivorous, zone);
                    result.Add(plant);
                }
                sqlite_conn.Close();
                cmd.Dispose();
                return result;
            }
        }

        public void savePlants(List<Plant> plants)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                foreach (Plant plant in plants)
                {
                    string statement = String.Format("SELECT count(*) FROM plants where name = '{0}'", plant.getName());
                    cmd.CommandText = statement;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        statement = String.Format("INSERT INTO plants(name, type, species, carnivorous, zone) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", plant.getName(), plant.getType(), plant.getSpecies(), plant.getIsCarnivorous(), plant.getGardenZone());
                        cmd.ExecuteNonQuery();
                    }
                }
                cmd.Dispose();
                sqlite_conn.Close();
            }
        }

        public void savePlant(Plant plant)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                string statement = String.Format("SELECT count(*) FROM plants where name = '{0}'", plant.getName());
                cmd.CommandText = statement;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    statement = String.Format("INSERT INTO plants(name, type, species, carnivorous, zone) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", plant.getName(), plant.getType(), plant.getSpecies(), plant.getIsCarnivorous(), plant.getGardenZone());
                    cmd.CommandText = statement;
                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                sqlite_conn.Close();
            }
        }

        public void deletePlant(Plant plant)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM plants WHERE name = '{0}'", plant.getName());
                    cmd.ExecuteNonQuery();
                }
                sqlite_conn.Close();
            }
        }

        public Plant findPlant(string plant)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                SQLiteDataReader reader;
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                string statement = String.Format("SELECT * FROM plants where name = '{0}'", plant);
                cmd.CommandText = statement;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader.GetString(0);
                    string type = reader.GetString(1);
                    string species = reader.GetString(2);
                    string carnivorous = reader.GetString(3);
                    string zone = reader.GetString(4);
                    Plant newPlant = new Plant(name, type, species, carnivorous, zone);
                    return newPlant;
                }
                else
                {
                    sqlite_conn.Close();
                    return new Plant("not", "found", "!", "", "");
                }
            }
        }

        public void editPlant(Plant oldPlant, Plant newPlant)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE plants SET name = '{0}', type = '{1}', species = '{2}', carnivorous = '{3}', zone = '{4}' WHERE name = '{5}'", newPlant.getName(), newPlant.getType(), newPlant.getSpecies(), newPlant.getIsCarnivorous(), newPlant.getGardenZone(), oldPlant.getName());
                    cmd.ExecuteNonQuery();
                }
                sqlite_conn.Close();
            }
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
                switch (criteria)
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
