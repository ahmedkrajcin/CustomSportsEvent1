﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Event
    {
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        private int eventID { get; set; }
        private DateTime Date { get; set; }
        private TimeSpan StartTime { get; set; }
        private Place placeId { get; set; }

        public Event(int eventID, DateTime date, TimeSpan startTime, Place placeId)
        {
            this.eventID = eventID;
            Date = date;
            StartTime = startTime;
            this.placeId = placeId;
        }

        public Event()
        {
            // Empty constructor. We'll use it to get an access to the Model methods
        }
        
        public dynamic getAllEvents()
        {
            // Define the query this method will run
            //string query = "SELECT * FROM Skiing;";
            string query = "SELECT * FROM Skiing";

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
        public dynamic getEventById(int id)
        {
            // Define the query this method will run
            string query = "SELECT * FROM Skiing WHERE EventID=" + id + ";";

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
        public dynamic getSingleEvent(int id)
        {
            // Query the database and retrieve the item with the passed id. After that, take the data and create a json object.
            return Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                eventName = "IUS Skiing",
                country = "Bosnia and Herzegovina"
            });
        }
    }
}