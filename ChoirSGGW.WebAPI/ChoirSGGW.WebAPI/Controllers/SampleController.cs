using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ChoirSGGW.WebAPI.Models;
using System.Web.Http.Cors;
using AutoMapper;

namespace ChoirSGGW.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class SampleController : ApiController
    {
        readonly ISampleService sampleService;

        public SampleController(ISampleService sampleService)
        {
            this.sampleService = sampleService;
        }

        // GET api/values
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        public IEnumerable<SampleDTO> Get()
        {
            return Mapper.Map<IEnumerable<SampleDTO>>(sampleService.GetAll());
        }

        // GET api/values/5
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        public SampleDTO Get(int id)
        {
            return Mapper.Map<SampleDTO>(sampleService.GetById(id));
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