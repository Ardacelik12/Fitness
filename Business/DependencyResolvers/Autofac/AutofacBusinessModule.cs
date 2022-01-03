using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IBlogPostManager>().As<IBlogPostService>().SingleInstance();
            builder.RegisterType<EfBlogPostDal>().As<IBlogPostDal>().SingleInstance();
            builder.RegisterType<ICampainManager>().As<ICampainService>().SingleInstance();
            builder.RegisterType<EfCampainDal>().As<ICampainDal>().SingleInstance();
            builder.RegisterType<IContactInfoManager>().As<IContactInfoService>().SingleInstance();
            builder.RegisterType<EfContactInfoDal>().As<IContactInfoDal>().SingleInstance();
            builder.RegisterType<ICustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<IMyProgrammesManager>().As<IMyProgrammesService>().SingleInstance();
            builder.RegisterType<EfMyProgrammesDal>().As<IMyProgrammesDal>().SingleInstance();
            builder.RegisterType<IOrderManager>().As<IOrderService>().SingleInstance();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>().SingleInstance();
            //
            builder.RegisterType<IProgrammeManager>().As<IProgrammeService>().SingleInstance();
            builder.RegisterType<EfProgrammeDal>().As<IProgrammeDal>().SingleInstance();
            builder.RegisterType<ISupplementManager>().As<ISupplementService>().SingleInstance();
            builder.RegisterType<EfSupplementDal>().As<ISupplementDal>().SingleInstance();
            builder.RegisterType<ITrainerManager>().As<ITrainerService>().SingleInstance();
            builder.RegisterType<EfTrainerDal>().As<ITrainerDal>().SingleInstance();
            builder.RegisterType<ICitiesManager>().As<ICitiesService>().SingleInstance();
            builder.RegisterType<EfCitiesDal>().As<ICitiesDal>().SingleInstance();



        }
    }
}
