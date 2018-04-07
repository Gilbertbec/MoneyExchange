using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExchangeWinFormApp
{
    using Autofac;
    using System.Reflection;

    class IocConfig
    {
        public static Autofac.IContainer Container { get; set; }

        public static void Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.Load("BLL")).PropertiesAutowired();
            Container = builder.Build();
        }

        private static ContainerBuilder GetContainerBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.Load("BLL")).PropertiesAutowired();
            return builder;
        }

        void Test()
        {
            IocConfig.Setup();
        }

  
    }
}
