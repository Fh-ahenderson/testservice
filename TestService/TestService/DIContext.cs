using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestService
{
    public class DIContext : DbContext
    {

        public DIContext() :base("DIContext")
        {

        }

        public DbSet<DIObject> DIObjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
