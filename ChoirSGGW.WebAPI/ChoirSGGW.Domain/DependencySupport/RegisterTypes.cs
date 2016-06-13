using ChoirSGGW.Domain.Services;
using ChoirSGGW.Domain.Services.Interfaces;
using ChoirSGGW.Domain.Services.TypesServices;
using ChoirSGGW.Domain.Services.TypesServices.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.DependencySupport
{
    public class RegisterTypes
    {
        private readonly IUnityContainer unityContainer;

        public RegisterTypes(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;        
        }

        public IUnityContainer BuildUnityContainer()
        {
            new ChoirSGGW.DataAccess.DependencySupport.RegisterTypes(unityContainer).BuildUnityContainer();

            //Services
            unityContainer.RegisterType<IAchievementService, AchievementService>();
            unityContainer.RegisterType<IConcertService, ConcertService>();
            unityContainer.RegisterType<IPhotoService, PhotoService>();
            unityContainer.RegisterType<IRepertoireService, RepertoireService>();
            unityContainer.RegisterType<ISampleService, SampleService>();
            unityContainer.RegisterType<ISongNoteService, SongNoteService>();
            unityContainer.RegisterType<ITopicalityService, TopicalityService>();
            unityContainer.RegisterType<IVideoService, VideoService>();

            //TypeServices
            unityContainer.RegisterType<IClotheTypesService, ClotheTypesService>();
            unityContainer.RegisterType<ISongsTypeService, SongsTypeService>();
            unityContainer.RegisterType<ITopicalityTypeService, TopicalityTypeService>();
            unityContainer.RegisterType<IUserTypesService, UserTypesService>();

            //unityContainer.RegisterType<IUserRepository, UserRepository>(new PerRequestLifetimeManager());

            return unityContainer;
        }
    }
}
