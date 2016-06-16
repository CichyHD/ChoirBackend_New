using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ChoirSGGW.WebAPI.Models;
using System.Web.Http.Cors;
using AutoMapper;
using ChoirSGGW.Entities.Models;

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
        public IEnumerable<SampleDTO> Get()
        {
            return Mapper.Map<IEnumerable<SampleDTO>>(sampleService.GetAll());
        }

        // GET api/values/5
        public SampleDTO Get(int id)
        {
            var temp = Mapper.Map<SampleDTO>(sampleService.GetById(id));
            return temp;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            sampleService.Create(
            Mapper.Map<Sample>(new SampleDTO()
            {
                name = "Jakaś tam próba",
                description = "Opis próby",
                isOpenToAll = 1,
                location = "Warsaw Centrum"
            }));
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