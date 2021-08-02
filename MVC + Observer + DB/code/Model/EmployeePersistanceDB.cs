using Garden.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class EmployeePersistanceDB
    {
        
        public EmployeePersistanceDB()
        {
           
        }

        public List<Employee> loadEmployees()
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                List<Employee> result = new List<Employee>();
                sqlite_conn.Open();
                SQLiteDataReader reader;
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM users";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string account = reader.GetString(0);
                    string password = reader.GetString(1);
                    string role = reader.GetString(2);
                    Employee emp = new Employee(role, account, password);
                    result.Add(emp);
                }
                sqlite_conn.Close();
                cmd.Dispose();
                return result;
            }
        }

        public void saveEmployees(List<Employee> employees)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                foreach (Employee emp in employees)
                {
                    string statement = String.Format("SELECT count(*) FROM users where account = '{0}'", emp.getAccount());
                    cmd.CommandText = statement;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        statement = String.Format("INSERT INTO users(account, password, role) VALUES('{0}', '{1}', '{2}')", emp.getAccount(), emp.getPassword(), emp.getRole());
                        cmd.CommandText = statement;
                        cmd.ExecuteNonQuery();
                    }
                }
                cmd.Dispose();
                sqlite_conn.Close();
            }
        }
        public void saveEmployee(Employee employee)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                string statement = String.Format("SELECT count(*) FROM users where account = '{0}'", employee.getAccount());
                cmd.CommandText = statement;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    statement = String.Format("INSERT INTO users(account, password, role) VALUES('{0}', '{1}', '{2}')", employee.getAccount(), employee.getPassword(), employee.getRole());
                    cmd.CommandText = statement;
                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                sqlite_conn.Close();
            }
        }

        public void deleteEmployee(Employee employee)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM users WHERE account = '{0}'", employee.getAccount());
                    cmd.ExecuteNonQuery();
                }
                sqlite_conn.Close();
            }
        }

        public void editEmployee(Employee oldEmployee, Employee newEmployee)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                using (SQLiteCommand cmd = sqlite_conn.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE users SET password = '{0}', role = '{1}' WHERE account = '{2}'", newEmployee.getPassword(), newEmployee.getRole(), oldEmployee.getAccount());
                    cmd.ExecuteNonQuery();
                }
                sqlite_conn.Close();
            }
        }

        public Employee findEmployee(string account)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                sqlite_conn.Open();
                SQLiteDataReader reader;
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                string statement = String.Format("SELECT * from users where account = '{0}'", account);
                cmd.CommandText = statement;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string acc = reader.GetString(0);
                    string password = reader.GetString(1);
                    string role = reader.GetString(2);
                    sqlite_conn.Close();
                    return new Employee(role, acc, password);
                }
                else
                {
                    sqlite_conn.Close();
                    return new Employee("-", "not", "found");
                }
            }

        }

        public List<Employee> filterEmployees(string role)
        {
            using (var sqlite_conn = new SQLiteConnection("Data Source=../../data/persistance.db;Version=3;Pooling=True;Max Pool Size=100;"))
            {
                List<Employee> result = new List<Employee>();
                sqlite_conn.Open();
                SQLiteDataReader reader;
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();
                string statement = String.Format("SELECT * from users where role = '{0}'", role);
                cmd.CommandText = statement;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string account = reader.GetString(0);
                    string password = reader.GetString(1);
                    Employee emp = new Employee(role, account, password);
                    result.Add(emp);
                }
                sqlite_conn.Close();
                cmd.Dispose();
                return result;
            }

        }

    }
}
