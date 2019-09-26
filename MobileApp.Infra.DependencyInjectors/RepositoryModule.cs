using System;
using System.Collections.Generic;
using System.Text;
using MobileApp.DAL.EF;
using MobileApp.DAL.EF.Repositories;
using MobileApp.Domain.Interfaces;
using Ninject;
using Ninject.Modules;

namespace MobileApp.Infra.DependencyInjectors
{
    public class RepositoryModule : NinjectModule
    {
        protected virtual void CreateContext()
        {
            // Context
            Bind<ContextDB>().To<ContextDB>().InSingletonScope();
        }

        public void DisposeContext()
        {
            var context = this.Kernel?.Get<ContextDB>();
            context?.Dispose();
        }

        public override void Load()
        {
            Bind<INoticiaRepository>().To<NoticiaRepository>();

            CreateContext();
        }
    }
}
