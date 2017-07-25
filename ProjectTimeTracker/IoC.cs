using System;
using System.Reflection;

using Autofac;

using ProjectTimeTracker.Forms;
using ProjectTimeTracker.Logging;
using ProjectTimeTracker.Services;

namespace ProjectTimeTracker
{
    public class IoC
    {
        private static IContainer _container;

        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterGeneric(typeof(NLogger<>)).As(typeof(ILogger<>));

            builder.Register(ctx => new AppForm(
                ctx.Resolve<ILogger<AppForm>>(),
                ctx.Resolve<IProjectsService>()
            )).As<AppForm>();
            builder.Register(ctx => new EntriesForm(
                ctx.Resolve<ILogger<EntriesForm>>(),
                ctx.Resolve<IProjectsService>()
            )).As<EntriesForm>();

            builder.RegisterType<ProjectsService>().As<IProjectsService>().SingleInstance();
            builder.RegisterType<ProjectsPersistenceService>().As<IProjectsPersistenceService>();

            _container = builder.Build();

            return _container;
        }

        public static T Resolve<T>() => _container.Resolve<T>();

        public static ILogger<T> ResolveLogger<T>() where T : class => _container.Resolve<ILogger<T>>();
    }
}
