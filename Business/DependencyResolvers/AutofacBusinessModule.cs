using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Core.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonManager>().As<IPersonService>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<EfPerDal>().As<IPerDal>();
            builder.RegisterType<PerManager>().As<IPerService>();
            builder.RegisterType<EfPerListDal>().As<IPerListDal>();
            builder.RegisterType<PerListManager>().As<IPerListService>();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>();

        }
    }
}
