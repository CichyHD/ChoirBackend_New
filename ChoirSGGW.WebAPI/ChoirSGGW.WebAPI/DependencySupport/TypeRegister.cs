//using ChoirSGGW.WebAPI.Controllers.ControllerActivator;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;

namespace ChoirSGGW.WebAPI.DependencySupport
{
    public class TypeRegister : ChoirSGGW.WebAPI.DependencySupport.ITypeRegister
    {
        private readonly IUnityContainer unityContainer;

        public TypeRegister(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer; 
        }

        public IUnityContainer BuildUnityContainer()
        {
            new ChoirSGGW.Domain.DependencySupport.RegisterTypes(unityContainer).BuildUnityContainer();

            return unityContainer;
        }
    }
}