using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Team
    {
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
        public Team ()
        {
            // Empty constructor
        }

        public string getAllTeams()
        {
            // Query the database and retrieve the all teams
            return "";
        }

        public dynamic getSingleTeam(int id)
        {
            // Query the database and retrieve the item with the passed id. After that, take the data and create a json object.
            return Newtonsoft.Json.JsonConvert.SerializeObject(new {
                teamName = "IUS Skiing",
                country = "Bosnia and Herzegovina"
            });
        }
    }
}