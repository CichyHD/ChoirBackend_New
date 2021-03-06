﻿using AutoMapper;
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
    public class ConcertController : ApiController
    {
        private readonly IConcertService concertService;

        public ConcertController(IConcertService concertService)
        {
            this.concertService = concertService;
        }

        /// <summary>
        /// Retrieve list of Concerts
        /// </summary>
        /// <returns></returns>
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        public IEnumerable<ConcertDTO> Get()
        {
            return Mapper.Map<IEnumerable<ConcertDTO>>(concertService.GetAll());
        }

        /// <summary>
        /// Retrieve one special concert by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        public ConcertDTO Get(int id)
        {
            var temp = Mapper.Map<ConcertDTO>(concertService.GetById(id));
            return temp;
        }

        /// <summary>
        /// Doing something
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
            concertService.Create(
                Mapper.Map<Concert>(
                new ConcertDTO()
            {
                ClotheType = null,
                ConcertUrl = "teststronakaski.cba.pl",
                Content = "jakis tam content",
                EndTime = DateTime.Now,
                IsVisibleIntoTimetable = true,
                MainPhoto = null,
                Members = null,
                Photos = null,
                Place = "Warsaw SGGW",
                Title = "Super nowy koncert",
                StartTime = DateTime.Now,
            }));
        }

        /// <summary>
        /// Doing something
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Doing something
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var tmp = concertService.GetById(id);
            concertService.Delete(tmp);
        }
    }
}