using ChoirSGGW.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ChoirSGGW.WebAPI.Models;
using AutoMapper;

namespace ChoirSGGW.WebAPI.Controllers
{
    public class VideoController : ApiController
    {
        readonly IVideoService videoService;

        public VideoController(IVideoService videoService)
        {
            this.videoService = videoService;
        }

        // GET api/values
        public IEnumerable<VideoDTO> Get()
        {
            return Mapper.Map<IEnumerable<VideoDTO>>(videoService.GetAll());
        }

        // GET api/values/5
        public VideoDTO Get(int id)
        {
            return Mapper.Map<VideoDTO>(videoService.GetById(id));
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
            var tmp = videoService.GetById(id);
            videoService.Delete(tmp);
        }
    }
}