using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Context : DbContext 
    {
        public DbSet <Songs> Songs { get; set; }
        public DbSet <Singer> Singers { get; set; }
    }
}
