//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : DataBaseInitializer.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace lhk.POS.Data.Initializers
{
    public class DataBaseInitializer<TContext> : IDatabaseInitializer<TContext> where TContext : DbContext
    {
        public void InitializeDatabase(TContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            bool dbExists = context.Database.Exists();
            bool modelChanged = false;

            if (dbExists && context.Database.CompatibleWithModel(throwIfNoMetadata: true) == false)
            {
                modelChanged = true;
                context.Database.Delete();
            }

            if (dbExists == false || modelChanged)
            {
                context.Database.Create();
                context.SaveChanges();

                //ExistedDbInstallation dbInit = new ExistedDbInstallation(context as IDbContext);
                
                //if(dbInit.isConnectToExistedDB) dbInit.MoveAllDb();

                SqlFileInstallation sqlfile = new SqlFileInstallation(context as IDbContext);
                sqlfile.InstallData();
            }

            bool createTables = false;
            //check whether tables are already created
            int numberOfTables = 0;
            foreach (var t1 in context.Database.SqlQuery<int>("SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE' "))
                numberOfTables = t1;

            createTables = numberOfTables == 0;

            if (createTables)
            {
                //create all tables
                var dbCreationScript = ((IObjectContextAdapter)context).ObjectContext.CreateDatabaseScript();
                context.Database.ExecuteSqlCommand(dbCreationScript);

                //Seed(context);
                context.SaveChanges();
            }
        }
    }
}
