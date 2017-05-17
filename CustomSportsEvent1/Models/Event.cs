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

        public Event()
        {
            // Empty constructor. We'll use it to get an access to the Model methods
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