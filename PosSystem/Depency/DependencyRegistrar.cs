using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using lhk.POS.Common;
using lhk.POS.Data;
using lhk.POS.Presentation.Presenters;
using lhk.POS.Presentation.Views;

namespace PosSystem.Depency
{
    public class DependencyRegistrar
    {

        public virtual void Register(ContainerBuilder builder)
        {
            // DB
            builder.RegisterType<PosDBContext>().As<IDbContext>();
            builder.Register<IDbContext>(c => new PosDBContext("PosDBConfig"));


            // Data repsoitory
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>));

        }
    }
}
