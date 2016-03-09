using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JsonProfessores.Models;

namespace JsonProfessores.Controllers
{
    public class ValuesController : ApiController
    {

        public IEnumerable<ProfessoresLinks> Get()
        {
            var l1 = new List<string> { "link1", "link2", "link3" };
            var l2 = new List<string> { "link4", "link5", "link6" };
            var l3 = new List<string> { "link7", "link8", "link9" };
            var p1 = new ProfessoresLinks { Links = l1, Professor = "professor1" };
            var p2 = new ProfessoresLinks { Links = l2, Professor = "professor2" };
            var p3 = new ProfessoresLinks { Links = l3, Professor = "professor3" };

            var profsLinks = new List<ProfessoresLinks>{p1, p2, p3};

            return profsLinks;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
