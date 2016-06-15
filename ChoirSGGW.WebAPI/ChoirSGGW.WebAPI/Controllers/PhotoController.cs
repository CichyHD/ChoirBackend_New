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
    public class PhotoController : ApiController
    {
        readonly IPhotoService photoService;

        public PhotoController(IPhotoService photoService)
        {
            this.photoService = photoService;
        }

        // GET api/values
        public IEnumerable<PhotoDTO> Get()
        {
            return Mapper.Map<IEnumerable<PhotoDTO>>(photoService.GetAll());
        }

        // GET api/values/5
        public PhotoDTO Get(int id)
        {
            return Mapper.Map<PhotoDTO>(photoService.GetById(id));
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
            var tmp = photoService.GetById(id);
            photoService.Delete(tmp);
        }
    }
}