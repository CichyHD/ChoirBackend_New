using AutoMapper;
using ChoirSGGW.Entities.Models;
using ChoirSGGW.Entities.Models.BasicModels;
using ChoirSGGW.Entities.Models.Types;
using ChoirSGGW.WebAPI.Models;
using ChoirSGGW.WebAPI.Models.BasicModels;
using ChoirSGGW.WebAPI.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoirSGGW.WebAPI.App_Start
{
    public class ConfigureMappings
    {
        public ConfigureMappings()
        {

        }

        public void CreateMappings()
        {
            CreateMapBasicModels();
            CreateMapTypes();
            CreateMapModels();
        }

        private void CreateMapBasicModels()
        {
            Mapper.CreateMap<BasicModel, BasicModelDTO>();
            Mapper.CreateMap<Event, EventDTO>();
            Mapper.CreateMap<VisibilityModel, VisibilityModelDTO>();

            Mapper.CreateMap<BasicModelDTO, BasicModel>();
            Mapper.CreateMap<EventDTO, Event>();
            Mapper.CreateMap<VisibilityModelDTO, VisibilityModel>();
        }

        private void CreateMapTypes()
        {
            Mapper.CreateMap<ClotheTypes, ClotheTypesDTO>();
            Mapper.CreateMap<SongsTypes, SongsTypeDTO>();
            Mapper.CreateMap<TopicalityType, TopicalityTypeDTO>();
            Mapper.CreateMap<UserTypes, UserTypesDTO>();

            Mapper.CreateMap<ClotheTypesDTO, ClotheTypes>();
            Mapper.CreateMap<SongsTypeDTO, SongsTypes>();
            Mapper.CreateMap<TopicalityTypeDTO, TopicalityType>();
            Mapper.CreateMap<UserTypesDTO, UserTypes>();
        }

        private void CreateMapModels()
        {
            Mapper.CreateMap<Achievement, AchievementDTO>();
            Mapper.CreateMap<Concert, ConcertDTO>();
            Mapper.CreateMap<Photo, PhotoDTO>();
            Mapper.CreateMap<Repertoire, RepertoireDTO>();
            Mapper.CreateMap<Sample, SampleDTO>();
            Mapper.CreateMap<SongNote, SongNoteDTO>();
            Mapper.CreateMap<Topicality, TopicalityDTO>();
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<Video, VideoDTO>();

            Mapper.CreateMap<AchievementDTO, Achievement>();
            Mapper.CreateMap<ConcertDTO, Concert>();
            Mapper.CreateMap<PhotoDTO, Photo>();
            Mapper.CreateMap<RepertoireDTO, Repertoire>();
            Mapper.CreateMap<SampleDTO, Sample>();
            Mapper.CreateMap<SongNoteDTO, SongNote>();
            Mapper.CreateMap<TopicalityDTO, Topicality>();
            Mapper.CreateMap<UserDTO, User>();
            Mapper.CreateMap<VideoDTO, Video>();
        }
    }
}