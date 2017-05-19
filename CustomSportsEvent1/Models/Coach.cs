using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Coach:Person
    {
        private const string connectionString = "server=sql8.freemysqlhosting.net;database=sql8174957;uid=sql8174957;pwd=C3Y3CcuXgu;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        private int coachID { get; set; }
        private int accreditationLevel { get; set; }
        private int yearsOfExpirience { get; set; }
        private int contact { get; set; }
        private String carriere { get; set; }
        private Team team { get; set; }

        public Coach(string name, string surname, DateTime birthdate, string birthplace, string info, string address,int coachID, int accreditationLevel, int yearsOfExpirience, int contact, string carriere, Team team): base( name,  surname,  birthdate, birthplace,  info,  address)
        {
            this.coachID = coachID;
            this.accreditationLevel = accreditationLevel;
            this.yearsOfExpirience = yearsOfExpirience;
            this.contact = contact;
            this.carriere = carriere;
            this.team = team;
        }
        public dynamic getAllPlayers()
        {
            // Define the query this method will run
            string query = "SELECT * FROM Coach;";

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