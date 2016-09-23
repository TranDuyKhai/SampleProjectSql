using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProjectSQL.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SampleProjectSQL.DataAccessLayer
{
    public class ComContext : DbContext
    {
        public ComContext()
            : base("ComContext")
        {}
        public DbSet<Work> works { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}