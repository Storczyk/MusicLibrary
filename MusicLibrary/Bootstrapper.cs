using System.Web.Http;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc3;
using MusicLibrary.Services;
using MusicLibrary.DAL;

namespace MusicLibrary
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // register dependency resolver for WebAPI RC
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();     
            
            //takie coœ robie po raz pierwszy :)   
            container.RegisterType<IAlbumRepository, AlbumRepository>().RegisterType<AlbumService,AlbumService>(new HierarchicalLifetimeManager())
                .RegisterType<IArtistRepository, ArtistRepository>().RegisterType<ArtistService, ArtistService>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}