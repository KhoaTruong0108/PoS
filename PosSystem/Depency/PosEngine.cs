using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using lhk.POS.Data;

namespace PosSystem.Depency
{
    public class PosEngine
    {
        IContainer container;

        SqlServerDataProvider sqlProvider;

        public PosEngine()
        {
            sqlProvider = new SqlServerDataProvider();

            var depency = new DependencyRegistrar();
            ContainerBuilder builder = new ContainerBuilder();

            depency.Register(builder);

            container = builder.Build();


        }

        public T Resolve<T>() where T : class
        {
            return container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return container.Resolve(type);
        }

    }
}
