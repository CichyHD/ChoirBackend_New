using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ChoirSGGW.WebAPI.Controllers
{
    public class RepertoireController : ApiController
    {
        readonly IRepertoireService repertoireService;

        public RepertoireController(IRepertoireService repertoireService)
        {
            this.repertoireService = repertoireService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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