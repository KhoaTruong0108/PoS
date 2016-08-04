using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lhk.POS.Data.Initializers
{
    class ExistedDatabaseInitializer<TContext> : DropCreateDatabaseIfModelChanges<TContext> where TContext : DbContext
    {

    }
}
