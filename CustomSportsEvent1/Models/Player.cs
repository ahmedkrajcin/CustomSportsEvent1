using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Player:Person
    {
        private int playerID { get; set; }
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
    }
}