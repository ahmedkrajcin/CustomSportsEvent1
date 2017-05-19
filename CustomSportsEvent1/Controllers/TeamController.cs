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
    public class TeamController : ApiController
    {        
        // GET: api/Team
        public string Get()
        {
            Team team = new Team();
            dynamic data = team.getAllTeams();
            return data;
        }

        // GET: api/Team/5
        public dynamic Get(int id)
        {
            Team team = new Team();

            dynamic data = team.getTeamById(id);
            return JsonConvert.DeserializeObject(data);
        }

        // POST: api/Team
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Team/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {

        }
    }
}
