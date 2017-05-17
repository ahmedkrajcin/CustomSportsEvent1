using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Coach:Person
    {
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
    }
}