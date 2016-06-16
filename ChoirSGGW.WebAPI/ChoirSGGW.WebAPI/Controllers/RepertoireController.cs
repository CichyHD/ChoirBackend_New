using AutoMapper;
using ChoirSGGW.Domain.Services.Interfaces;
using ChoirSGGW.Entities.Models;
using ChoirSGGW.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ChoirSGGW.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class RepertoireController : ApiController
    {
        readonly IRepertoireService repertoireService;

        public RepertoireController(IRepertoireService repertoireService)
        {
            this.repertoireService = repertoireService;
        }

        // GET api/values
        public IEnumerable<RepertoireDTO> Get()
        {
            var temp = Mapper.Map<IEnumerable<RepertoireDTO>>(repertoireService.GetAll());
            return temp;
        }

        // GET api/values/5
        public RepertoireDTO Get(int id)
        {
            return Mapper.Map<RepertoireDTO>(repertoireService.GetById(id));
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            repertoireService.Create(
            Mapper.Map<Repertoire>(
            new RepertoireDTO()
            {
                album = "sweet album",
                artist = "Justin Bieber",
                description = "super śliczna piosenka",
                genre = "Pop",
                length = "1h",
                title = "If i was your boifriend",
                IsApproved = true
            }));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var tmp = repertoireService.GetById(id);
            repertoireService.Delete(tmp);
        }
    }
}