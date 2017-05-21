using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomSportsEvent1.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CustomSportsEvent1.Controllers
{   
    public class EventController : ApiController
    {
        // GET: api/Event
        public dynamic Get()
        {Skiing event1 = new Skiing();
            Player list = new Player();
           
           
            
            return event1.getAllSkiings();
            //return JsonConvert.DeserializeObject(data);
        }

        // GET: api/Event/5
        public dynamic Get(int id)
        {
            Skiing event1 = new Skiing();

           return event1.getSkiingById(id);
            //return JsonConvert.DeserializeObject(data);
        }

        // POST: api/Event
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Event/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Event/5
        public void Delete(int id)
        {
        }
    }
}
