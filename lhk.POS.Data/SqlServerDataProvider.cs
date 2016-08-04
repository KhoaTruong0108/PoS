//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : SqlServerDataProvider.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using lhk.POS.Data.Initializers;

namespace lhk.POS.Data
{
    public class SqlServerDataProvider
    {
        /// <summary>
        /// Initialize connection factory
        /// </summary>
        public virtual void InitConnectionFactory()
        {
            var connectionFactory = new SqlConnectionFactory();
            //TODO fix compilation warning (below)
            #pragma warning disable 0618
            Database.DefaultConnectionFactory = connectionFactory;
        }

        /// <summary>
        /// Initialize database
        /// </summary>
        public virtual void InitDatabase()
        {
            InitConnectionFactory();
            SetDatabaseInitializer();
        }

        /// <summary>
        /// Set database initializer
        /// </summary>
        public virtual void SetDatabaseInitializer()
        {
            var initializer = new ExistedDatabaseInitializer<PosDBContext>();
            Database.SetInitializer(initializer);
        }
    }
}
