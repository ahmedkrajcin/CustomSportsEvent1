using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Place
    {
        private int placeID { get; set; }
        private String placeName { get; set; }
        private String type { get; set; }
        private String address { get; set; }
        private int maxAudience { get; set; }

        public Place(int placeID, string placeName, string type, string address, int maxAudience)
        {
            this.placeID = placeID;
            this.placeName = placeName;
            this.type = type;
            this.address = address;
            this.maxAudience = maxAudience;
        }
    }
}