using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Country
    {
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        private int countryID { get; set; }
        private String countryName { get; set; }
        private int numberOfTeams { get; set; }
        private int goldMedals { get; set; }
        private int silverMedals{get; set;}
        private int bronzeMedals { get; set; }
        private String info { get; set; }

        public Country(int countryID, string countryName, int numberOfTeams, int goldMedals, int silverMedals, int bronzeMedals, string info)
        {
            this.countryID = countryID;
            this.countryName = countryName;
            this.numberOfTeams = numberOfTeams;
            this.goldMedals = goldMedals;
            this.silverMedals = silverMedals;
            this.bronzeMedals = bronzeMedals;
            this.info = info;
        }
        public dynamic getAllCountries()
        {
            // Define the query this method will run
            string query = "SELECT * FROM Country;";

            // Initialize an empty DataTable object
            DataTable dt = new DataTable();

            try
            {
                // Open the database connection
                connection.Open();

                //Pass the query command, and selected database connection
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                // Fill the retrieved data from the database into earlier created dt DataTable
                da.Fill(dt);

                // Convert the dataTable into a valid JSON format
                string json = JsonConvert.SerializeObject(dt, Formatting.Indented);

                // Convert previously created json data, into valid and formatted json data
                var preparedJson = JsonConvert.DeserializeObject(json);

                // Close the database connection
                connection.Close();

                return (preparedJson);

            }

            catch (Exception ex)
            {
                return ("Connection failed");
            }
        }
        public dynamic getCountryById(int id)
        {
            // Define the query this method will run
            string query = "SELECT * FROM Country WHERE id=" + id + ";";

            // Initialize an empty DataTable object
            DataTable dt = new DataTable();

            try
            {
                // Open the database connection
                connection.Open();

                //Pass the query command, and selected database connection
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                // Fill the retrieved data from the database into earlier created dt DataTable
                da.Fill(dt);

                // Convert the dataTable into a valid JSON format
                string json = JsonConvert.SerializeObject(dt, Formatting.Indented);

                // Convert previously created json data, into valid and formatted json data
                var preparedJson = JsonConvert.DeserializeObject(json);

                // Close the database connection
                connection.Close();

                return (preparedJson);

            }

            catch (Exception ex)
            {
                return ("Connection failed");
            }
        }
    }
}