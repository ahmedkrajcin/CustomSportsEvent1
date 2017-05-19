using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomSportsEvent1.Models;

namespace CustomSportsEvent1.Controllers
{   
    public class EventController : ApiController
    {
        // GET: api/Event
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Event/5
        public string Get(int id)
        {
            Event event1 = new Event();

            dynamic data = event1.getEventById(id);
            return JsonConvert.DeserializeObject(data);
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
