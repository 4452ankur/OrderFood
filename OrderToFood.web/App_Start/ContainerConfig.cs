using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OrderFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OrderToFood.web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpconfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            //Inmemory data
           // builder.RegisterType<RestruantsData>().As<IRestruant>().SingleInstance();

            // Sql Data
            builder.RegisterType<SqlRestruantData>().As<IRestruant>().InstancePerRequest();
            builder.RegisterType<OrderFoodDbContex>().InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //Api configuration
            httpconfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}