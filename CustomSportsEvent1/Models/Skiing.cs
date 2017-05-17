using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Skiing:Event
    {
        private int skiingID { get; set; }
        private String skiingType { get; set; }
        private int numberOfPlayers { get; set; }
        private TimeSpan bestTime { get; set; }
        private int lenghtOfTrack { get; set; }
        private Player[][] playerList { get; set; }
        private Player[][] rankingList { get; set; }



        public Skiing(int eventID, DateTime date, TimeSpan startTime, Place placeId,int skiingID, string skiingType, int numberOfPlayers, TimeSpan bestTime, int lenghtOfTrack, Player[][] playerList, Player[][] rankingList) : base(eventID, date, startTime, placeId)
        {
            this.skiingID = skiingID;
            this.skiingType = skiingType;
            this.numberOfPlayers = numberOfPlayers;
            this.bestTime = bestTime;
            this.lenghtOfTrack = lenghtOfTrack;
            this.playerList = playerList;
            this.rankingList = rankingList;
        }
    }
}