using AutoMapper;
using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ChoirSGGW.WebAPI.Models;

namespace ChoirSGGW.WebAPI.Controllers
{
    public class TopicalityController : ApiController
    {
        readonly ITopicalityService TopicalityService;

        public TopicalityController(ITopicalityService TopicalityService)
        {
            this.TopicalityService = TopicalityService;
        }

        // GET api/values
        public IEnumerable<TopicalityDTO> Get()
        {
            return Mapper.Map<IEnumerable<TopicalityDTO>>(TopicalityService.GetAll());
        }

        // GET api/values/5
        public TopicalityDTO Get(int id)
        {
            return Mapper.Map<TopicalityDTO>(TopicalityService.GetById(id));
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
            var tmp = TopicalityService.GetById(id);
            TopicalityService.Delete(tmp);
        }
    }
}