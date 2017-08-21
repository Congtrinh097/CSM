using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM.Entities
{
    public partial class InstanceEntities : DbContext
    {
        public InstanceEntities(DbContextOptions<InstanceEntities> options) : base(options)
        {
        }
        public DbSet<Test> Test { get; set; }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
}
