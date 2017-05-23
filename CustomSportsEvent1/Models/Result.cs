using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Data;

namespace CustomSportsEvent1.Models
{
    public class Result
    { public string playerId { get; set; }
        public string result { get; set; }
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public dynamic getResultById(int id)
    {
        // Define the query this method will run
        string query = "SELECT time, name, surname, flag  FROM rankingList"+id+ " JOIN Player ON rankingList" + id + ".PlayerId=Player.PlayerID  JOIN Country ON Player.countryId=Country.countryId;";

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
    public class RootObject
    {
        public Result person { get; set; }
    }
}