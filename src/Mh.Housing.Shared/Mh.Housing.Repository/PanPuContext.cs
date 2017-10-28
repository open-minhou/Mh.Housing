using Mh.Housing.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mh.Housing.Repository
{
    public class PanPuContext:DbContext
    {
        public PanPuContext(string connectionString) : base(connectionString) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>();
            modelBuilder.Entity<ClientMenu>();
            modelBuilder.Entity<Locations>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
