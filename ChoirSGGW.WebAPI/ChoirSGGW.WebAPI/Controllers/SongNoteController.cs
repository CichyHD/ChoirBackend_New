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
    public class SongNoteController : ApiController
    {
        readonly ISongNoteService songNoteService;

        public SongNoteController(ISongNoteService songNoteService)
        {
            this.songNoteService = songNoteService;
        }

        // GET api/values
        public IEnumerable<SongNoteDTO> Get()
        {
            return Mapper.Map<IEnumerable<SongNoteDTO>>(songNoteService.GetAll());
        }

        // GET api/values/5
        public SongNoteDTO Get(int id)
        {
            return Mapper.Map<SongNoteDTO>(songNoteService.GetById(id));
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
            var tmp = songNoteService.GetById(id);
            songNoteService.Delete(tmp);
        }
    }
}