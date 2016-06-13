using System;
namespace ChoirSGGW.WebAPI.DependencySupport
{
    interface ITypeRegister
    {
        Microsoft.Practices.Unity.IUnityContainer BuildUnityContainer();
    }
}
