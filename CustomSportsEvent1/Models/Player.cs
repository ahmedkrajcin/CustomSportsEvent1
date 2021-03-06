﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Player:Person
    {
        // Declare the database details
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        private int playerID { get; set; }
        private string gender { get; set; }
        private String playerType { get; set; }
        private int ranking { get; set; }
        private bool injured { get; set; }
        private int playerNumber { get; set; }
        private String carrier { get; set; }
        private int goldMedals { get; set; }
        private int silverMedals { get; set; }
        private int bronzeMedals { get; set; }

        public Player(string name, string surname, DateTime birthdate, string birthplace, string info, string address,int playerID, string playerType, int ranking, bool injured, int playerNumber, string carrier, int goldMedals, int silverMedals, int bronzeMedals):base(name, surname, birthdate, birthplace, info, address)
        {
            this.playerID = playerID;
            this.playerType = playerType;
            this.ranking = ranking;
            this.injured = injured;
            this.playerNumber = playerNumber;
            this.carrier = carrier;
            this.goldMedals = goldMedals;
            this.silverMedals = silverMedals;
            this.bronzeMedals = bronzeMedals;
        }
        // <author>Tarik Fojnica</author>

        // Empty constructor
        public Player()
        {

        }

        public dynamic getAllPlayers()
        {
            // Define the query this method will run
            string query = "SELECT * FROM Player;";
        

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
        public dynamic getPlayerById(int id)
        {
            // Define the query this method will run
            string query = "SELECT * FROM Player WHERE PlayerID=" + id + ";";
            

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