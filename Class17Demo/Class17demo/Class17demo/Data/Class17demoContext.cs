using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Class17demo.Models
{
    public class Class17demoContext : DbContext
    {
        public Class17demoContext (DbContextOptions<Class17demoContext> options)
            : base(options)
        {
        }

        public DbSet<Class17demo.Models.Destination> Destination { get; set; }
        public DbSet<Class17demo.Models.Supplies> Supplies { get; set; }

    }
}
