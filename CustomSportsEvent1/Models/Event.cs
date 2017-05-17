using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Event
    {
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
    }
}