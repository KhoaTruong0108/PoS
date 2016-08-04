using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Autofac;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pos.DataBaseTest
{
    [TestClass]
    public class DBInitializerTest
    {
        [TestMethod]
        public void Can_generate_schema()
        {
            Database.SetInitializer<PosDBContext>(null);
            var ctx = new PosDBContext("Test");
            string result = ctx.CreateDatabaseScript();
            //result.ShouldNotBeNull();
            Console.Write(result);
        }

        [TestMethod]
        public void InitialDB()
        {


            ContainerBuilder builder = new ContainerBuilder();

            builder.Register<DbContext>(c => new PosDBContext("PosTest"));

            //builder.RegisterType<EfRepository<BaseEntity>>().As<IRepository<BaseEntity>>().InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            IContainer container = builder.Build();

            SqlServerDataProvider provider = new SqlServerDataProvider();
            provider.InitDatabase();

            //PosDBContext context = new PosDBContext("PosTest");
            //var product = new EfRepository<Product>(context);
            //product.Insert(new Product());

            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IRepository<Product>>();
                writer.Insert(new Product());
            }

        }

        [TestMethod]
        public void CreateDB()
        {
            //Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
            PosDBContext context = new PosDBContext("PosTest");
            context.Database.Delete();
            context.Database.Create();
        }

        [TestMethod]
        public void InstallSampleData()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.Register<IDbContext>(c => new PosDBContext("PosTest"));


            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            IContainer container = builder.Build();

            SqlServerDataProvider provider = new SqlServerDataProvider();
            provider.InitDatabase();

            using (var scope = container.BeginLifetimeScope())
            {
                var context = scope.Resolve<IDbContext>();

                var sqlFile = new SqlFileInstallation(context);
                sqlFile.InstallData();
            }
        }
    }
}
