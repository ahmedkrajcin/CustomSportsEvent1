using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomSportsEvent1.Models;
namespace CustomSportsEvent1.Controllers
{
    public class TeamController : ApiController
    {
        Team team = new Team();
        
        // GET: api/Team
        public string Get()
        {
            return team.getAllTeams();
        }

        // GET: api/Team/5
        public string Get(int id)
        {
            return team.getSingleTeam(id);
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
