using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Team
    {
        // Declare the database details
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection cnn = new MySqlConnection(connectionString);

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

        public string getAllTeams()
        {
            try
            {
                cnn.Open();
                return ("connection opened successfully");
                cnn.Close();
            }

            catch (Exception ex)
            {
                return ("Connection failed");
                System.Diagnostics.Debug.WriteLine("The error occured");
            }

            // Query the database and retrieve the all teams
            return "";
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