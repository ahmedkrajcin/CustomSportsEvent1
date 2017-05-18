using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// <author>Ahmed Krajcin</author>
namespace CustomSportsEvent1.Models
{
    public class Person
    {   
        private String name { get; set; }
        private String surname { get; set; }
        private DateTime birthdate { get; set; }
        private String birthplace { get; set; }
        private String info { get; set; }
        private String address { get; set; }

        public Person(string name, string surname, DateTime birthdate, string birthplace, string info, string address)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.birthplace = birthplace;
            this.info = info;
            this.address = address;
        }

        public Person()
        {

        }
    }
}