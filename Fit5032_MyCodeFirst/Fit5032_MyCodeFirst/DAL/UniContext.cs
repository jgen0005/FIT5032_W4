using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Fit5032_MyCodeFirst.Models;

namespace Fit5032_MyCodeFirst.DAL
{
    public class UniContext: DbContext
    {
        public UniContext() : base("UniContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}