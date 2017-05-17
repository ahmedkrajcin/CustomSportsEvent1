using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Country
    {
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
    }
}