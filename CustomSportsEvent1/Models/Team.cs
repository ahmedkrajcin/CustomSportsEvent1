using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Team
    {
        // Declare the database details
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        private int teamID { get; set; }
        private int size { get; set; }
        private String teamName { get; set; }
        private Country country { get; set; }

        public Team(int teamID, int size, string teamName, Country country)
        {
            this.teamID = teamID;
            this.size = size;
            this.teamName = teamName;
            this.country = country;
        }

        // Empty constructor
        public Team ()
        {
           
        }

        public dynamic getAllTeams()
        {
            // Define the query this method will run
            string query = "SELECT * FROM Team;";

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
        public dynamic getTeamById(int id)
        {
            // Define the query this method will run
            string query = "SELECT * FROM Team WHERE TeamID=" + id + ";";

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
        public dynamic getSingleTeam(int id)
        {
            // Query the database and retrieve the item with the passed id. After that, take the data and create a json object.
            // Check http://stackoverflow.com/questions/2979922/how-to-convert-datatable-to-json-string-using-json-net for example
            return Newtonsoft.Json.JsonConvert.SerializeObject(new {
                teamName = "IUS Skiing",
                country = "Bosnia and Herzegovina"
            });
        }
    }
}