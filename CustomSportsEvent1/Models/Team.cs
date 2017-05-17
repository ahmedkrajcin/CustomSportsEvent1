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
    }
}