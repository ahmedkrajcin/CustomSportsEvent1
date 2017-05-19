using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomSportsEvent1.Models;
using Newtonsoft.Json;

namespace CustomSportsEvent1.Controllers
{
    public class PlayerController : ApiController
    {
        // GET: api/Player
        public dynamic Get()
        {
            // Initialize and empty player object which will have an access to all Player model methods
            Player player = new Player();

            // call getAllPlayers() method which consists of the required data 
            return player.getAllPlayers();
        }

        // GET: api/Player/5
        public string Get(int id)
        {
            Player player = new Player();

            dynamic data = player.getPlayerById(id);
            return JsonConvert.DeserializeObject(data);
        }

        // POST: api/Player
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Player/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Player/5
        public void Delete(int id)
        {
        }
    }
}
