using CustomSportsEvent1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomSportsEvent1.Controllers
{
    public class PlaceController : ApiController
    {
        public dynamic Get()
        {

            Place event1 = new Place();

            return event1.getAllPlaces();
            //return JsonConvert.DeserializeObject(data);
        }

        // GET: api/Place/5
        public dynamic Get(int id)
        {
            Place event1 = new Place();

            return event1.getPlaceById(id);
            //return JsonConvert.DeserializeObject(data);
        }

        // POST: api/Place
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Place/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Place/5
        public void Delete(int id)
        {
        }
    }
}
