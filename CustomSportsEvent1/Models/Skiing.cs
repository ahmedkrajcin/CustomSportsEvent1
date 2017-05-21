using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Skiing:Event
    {
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        private int skiingID { get; set; }
        private String skiingType { get; set; }
        private int numberOfPlayers { get; set; }
       
        private int lenghtOfTrack { get; set; }
        private int playerList { get; set; }
        private int rankingList { get; set; }

        public Skiing() { }


        public Skiing(int eventID, DateTime date, TimeSpan startTime, Place placeId,int skiingID, string skiingType, int numberOfPlayers,  int lenghtOfTrack, int playerList, int rankingList) : base(eventID, date, startTime, placeId)
        {
            this.skiingID = skiingID;
            this.skiingType = skiingType;
            this.numberOfPlayers = numberOfPlayers;
            
            this.lenghtOfTrack = lenghtOfTrack;
            this.playerList = playerList;
            this.rankingList = rankingList;
        }
        public dynamic getAllSkiings()
        {
            // Define the query this method will run
            string query = "SELECT * FROM Skiing;";

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
        public dynamic getSkiingById(int id)
        {
            // Define the query this method will run
            string query = "SELECT * FROM Skiing WHERE SkiingId=" + id + ";";

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